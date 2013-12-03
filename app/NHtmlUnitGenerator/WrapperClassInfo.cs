#region License

// --------------------------------------------------
// Copyright © 2003-2011 OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

using com.gargoylesoftware.htmlunit;

namespace NHtmlUnit.Generator
{
    public class WrapperClassInfo
    {
        private readonly List<WrapperConstructorInfo> constructors;
        private readonly Dictionary<string, WrapperMethodInfo> methods;
        private readonly Dictionary<string, WrapperPropInfo> properties;
        private readonly List<WrapperStaticPublicField> staticPublicFields;
        private readonly Type wrappedType;
        private readonly WrapperRepository wrapperRepository;
        private readonly string htmlUnitVersion; 


        public WrapperClassInfo(Type wrappedFromType, WrapperRepository wrapperRepository)
        {
            this.wrapperRepository = wrapperRepository;
            this.wrappedType = wrappedFromType;
            this.properties = new Dictionary<string, WrapperPropInfo>();
            this.methods = new Dictionary<string, WrapperMethodInfo>();
            this.constructors = new List<WrapperConstructorInfo>();
            this.staticPublicFields = new List<WrapperStaticPublicField>();
            ScanMembers(wrappedFromType);
            Assembly htmlUnitAssembly = Assembly.GetAssembly(typeof(WebClient));
            htmlUnitVersion = htmlUnitAssembly.GetName().Version.ToString();
        }


        public List<WrapperConstructorInfo> Constructors
        {
            get { return this.constructors; }
        }

        public string FilePathBase
        {
            get
            {
                var names = RelativeClassName.Split('.');
                var directories = new[] { Repository.TargetDirectory, "Generated" }
                    .Union(names)
                    .ToArray();

                return Path.Combine(directories);
            }
        }

        public WrapperClassInfo InheritsFrom { get; set; }

        public bool IsInterface
        {
            get { return WrappedType.IsInterface; }
        }

        public Dictionary<string, WrapperMethodInfo> Methods
        {
            get { return this.methods; }
        }

        public Dictionary<string, WrapperPropInfo> Properties
        {
            get { return this.properties; }
        }

        public string RelativeClassName
        {
            get { return Repository.GetRelativeClassName(this); }
        }

        public WrapperRepository Repository
        {
            get { return this.wrapperRepository; }
        }

        public List<WrapperStaticPublicField> StaticPublicFields
        {
            get { return this.staticPublicFields; }
        }

        public string TargetBaseName
        {
            get
            {
                if (WrappedBase != null && Repository.TypeIsWrapped(WrappedBase))
                    return Repository.GetTargetFullName(WrappedBase);

                return "ObjectWrapper";
            }
        }

        public string TargetFullName
        {
            get { return Repository.GetTargetFullName(this); }
        }

        public string TargetNameWithoutNamespace
        {
            get { return TargetFullName.Substring(TargetFullName.LastIndexOf('.') + 1); }
        }

        public string TargetNamespace
        {
            get
            {
                var names = TargetFullName.Split('.')
                    .Select(x => String.Concat(x.Substring(0, 1).ToUpper(), x.Substring(1)))
                    .ToArray();

                string ns = String.Join(".", names.Take(names.Length - 1));

                return ns;
            }
        }

        public Type WrappedBase
        {
            get { return this.wrappedType.BaseType; }
        }

        public Type WrappedType
        {
            get { return this.wrappedType; }
        }

        //public string EncodedClassName { get { return 

        public void GenerateClassCode(StringBuilder sb)
        {
            GeneratePartialClassHeader(sb, false);

            sb.AppendFormat(
                @"      static {0}()
      {{
         ObjectWrapper.RegisterWrapperCreator(({1} o) =>
            new {0}(o));
      }}

",
                TargetNameWithoutNamespace,
                WrappedType.FullName);

            sb.AppendFormat("      public {0}({1} wrappedObject) : base(wrappedObject) {{}}\r\n",
                            TargetNameWithoutNamespace,
                            WrappedType.FullName);

            sb.AppendLine();

            sb.AppendFormat("      public {0}{1} WObj\r\n",
                            TargetBaseName == "ObjectWrapper" ? "" : "new ",
                            WrappedType.FullName);
            sb.AppendFormat("      {{\r\n         get {{ return ({0})WrappedObject; }}\r\n      }}\r\n",
                            WrappedType.FullName);
            sb.AppendLine();

            foreach (var wsf in StaticPublicFields)
                wsf.GenerateStaticFieldWrapper(sb);

            foreach (var wc in Constructors)
                wc.GenerateConstructorCode(sb);

            foreach (var wpi in Properties.Where(x => ShouldMapAsProperty(x)))
                wpi.Value.GeneratePropertyCode(sb);

            foreach (var wm in Methods)
                wm.Value.GenerateMethodCode(sb);

            GeneratePartialClassFooter(sb);
        }


        private bool ShouldMapAsProperty(KeyValuePair<string, WrapperPropInfo> x)
        {
            if (x.Value.GetterMethod == null)
            {
                //TODO: Consider this. When method identified as property has no GetterMethod, the SetterMethod is neither mapped as property or method. [TM]
                //if (!Methods.ContainsKey(x.Value.SetterMethod.ToString()))
                //    Methods.Add(x.Value.SetterMethod.ToString(), new WrapperMethodInfo(this, x.Value.SetterMethod));
                return false;
            }

            if (x.Value.SetterMethod != null
                && x.Value.GetterMethod.ReturnType != x.Value.SetterMethod.GetParameters().First().ParameterType)
            {
                Methods.Add(x.Value.GetterMethod.ToString(), new WrapperMethodInfo(this, x.Value.GetterMethod));
                Methods.Add(x.Value.SetterMethod.ToString(), new WrapperMethodInfo(this, x.Value.SetterMethod));

                return false;
            }

            return true;
        }


        public void GenerateInterfaceCode(StringBuilder sb)
        {
            // {0} is namespace declarations
            // {1} is namespace of interface
            // {2} is name of interface
            // {3} is to be filled with methods and properties etc..

            var baseInterfaceString = new StringBuilder();

            foreach (var baseInterface in WrappedType.GetInterfaces().Where(i => Repository.TypeIsWrapped(i)))
            {
                Repository.MarkUsageOfType(baseInterface);
                baseInterfaceString.Append(", ");
                baseInterfaceString.Append(Repository.GetTargetFullName(baseInterface));
            }

            var fileFmt =
                @"// Wrapper for {5}
{0}

namespace {1}
{{
   public interface {2} : NHtmlUnit.IObjectWrapper{3}
   {{
{4}
   }}
}}
";
            var namespaceIncludes =
                @"// Generated class v" + htmlUnitVersion + @", don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

";


            var body = new StringBuilder();

#warning HACK HACK HACK ON
            if (!WrappedType.FullName.StartsWith("org.w3c.dom."))
            {
                foreach (var wpi in Properties.Where(x => x.Value.GetterMethod != null))
                    wpi.Value.GeneratePropertyCode(body);

                foreach (var wm in Methods)
                    wm.Value.GenerateMethodCode(body);
            }

            sb.AppendFormat(
                fileFmt,
                namespaceIncludes,
                TargetNamespace,
                TargetNameWithoutNamespace,
                baseInterfaceString,
                body,
                WrappedType.FullName);
        }


        public void GenerateUserClassFile()
        {
            StringBuilder sb = new StringBuilder();

            if (!IsInterface)
            {
                GeneratePartialClassHeader(sb, true);
                GeneratePartialClassFooter(sb);
            }

            var names = RelativeClassName.Split('.');
            var directories = new[] { Repository.TargetDirectory, "NonGenerated" }
                .Union(names)
                .ToArray();

            var fileName = Path.Combine(directories) + ".cs";

            Repository.WriteTextToFile(fileName, sb.ToString(), false /* Don't overwrite! */);
        }


        public bool HasNamespaceEntryForType(Type PropertyType)
        {
            const string namespaceListText =
                @"using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;";

            List<string> nameSpaceList = namespaceListText.Split(';')
                .Select(s => (s.Trim("\r\n \t;".ToCharArray())))
                .Where(s => (s.StartsWith("using ")))
                .Select(s => (s.Substring("using ".Length).Trim()))
                .Where(s => (!String.IsNullOrWhiteSpace(s)))
                .Concat(new[] { TargetNamespace }).ToList();

            return nameSpaceList.Contains(PropertyType.Namespace);
        }


        private static bool IsMethodSignatureCastable(MethodInfo castTo, MethodInfo castFrom)
        {
            var targetParameters = castTo.GetParameters();
            var sourceParameters = castFrom.GetParameters();

            if (targetParameters.Length != sourceParameters.Length)
                return false;

            for (var i = 0; i < targetParameters.Length; i++)
            {
                var tp = targetParameters[i];
                var sp = sourceParameters[i];

                if (tp.ParameterType != sp.ParameterType)
                    return false;
            }

            return castTo.ReturnType.IsAssignableFrom(castFrom.ReturnType);
        }


        private void GeneratePartialClassFooter(StringBuilder sb)
        {
            sb.AppendLine("   }");

            sb.AppendLine("\r\n\r\n}");
        }


        private void GeneratePartialClassHeader(StringBuilder sb, bool isUserFile)
        {
            
            sb.AppendLine("// Generated class v" + htmlUnitVersion + (isUserFile ? ", can be modified" : ", don't modify"));
            sb.AppendLine();
            if (!isUserFile)
            {
                sb.AppendLine("using System;");
                sb.AppendLine("using System.Collections.Generic;");
                sb.AppendLine("using System.Collections.Specialized;");
                sb.AppendLine("using System.Linq;");
                sb.AppendLine("using System.Text;");
                sb.AppendLine();
            }
            sb.Append("namespace ");
            sb.AppendLine(TargetNamespace);
            sb.AppendLine("{");
            
            var interfaceList = new StringBuilder();

            if (isUserFile)
                sb.AppendLine("   public partial class " + TargetNameWithoutNamespace);
            else
            {
                IEnumerable<Type> wrappedInterfaces = WrappedType
                    .GetInterfaces()
                    .Where(i => Repository.TypeIsWrapped(i));

                foreach (var wrappedInterface in wrappedInterfaces)
                {
                    interfaceList.AppendFormat(", {0}", Repository.GetTargetFullName(wrappedInterface));
                    Repository.MarkUsageOfType(wrappedInterface);
                }

                if (WrappedBase != null && Repository.TypeIsWrapped(WrappedBase))
                    Repository.MarkUsageOfType(WrappedBase);

                sb.AppendFormat(
                    "   public partial class {0} : {1}{2}\r\n",
                    TargetNameWithoutNamespace,
                    TargetBaseName,
                    interfaceList
                    );
            }

            sb.AppendLine("   {");
        }


        private WrapperPropInfo GetWrapperPropInfoFor(Dictionary<string, WrapperPropInfo> dict, string propName)
        {
            WrapperPropInfo wpi;

            if (!dict.TryGetValue(propName, out wpi))
            {
                wpi = new WrapperPropInfo(this, propName, Repository);
                dict[propName] = wpi;
            }

            return wpi;
        }


        private void ScanMembers(Type type)
        {
            // The special meal of today: find interfaces that is new on this class, and clashes with existing fields!

            var newInterfacesForThisSubclass =
                WrappedType
                    .GetInterfaces()
                    .Except(WrappedBase != null ? WrappedBase.GetInterfaces() : new Type[] { })
                    .Where(i => Repository.TypeIsWrapped(i));

            var existingNames = new HashSet<string>(
                Methods.Values.Select(m => m.TargetMethodInfo.Name));

            var methodsOfNewInterfaces =
                newInterfacesForThisSubclass
                    .SelectMany(il => il.GetMethods())
                    .Where(m => existingNames.Contains(m.Name))
                    .ToArray();

            foreach (var wmiRo in Methods.Values)
            {
                var wmi = wmiRo; // To get correct lambda closure!

                var conflictingMethods = methodsOfNewInterfaces
                    .Where(m => wmi.TargetMethodInfo.Name == m.Name)
                    .Where(m => IsMethodSignatureCastable(m, wmi.TargetMethodInfo));

                foreach (var cm in conflictingMethods)
                    Console.WriteLine("Conflicting method: " + cm);

                if (conflictingMethods.Count() > 0)
                    throw new InvalidOperationException();
            }

            // First extract all properties and methods

            IEnumerable<MethodInfo> nonObsoleteMethods = type
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)
                .Where(mi => (mi.GetCustomAttributes(typeof(ObsoleteAttribute), true).Count() == 0))
                .Where(mi => (!mi.Name.Contains("<")))
                // TODO: Support methods with weird names that starts with "<bridge>"
                .Where(
                    mi => (type.BaseType != null
                               ? type.BaseType.GetMethod(
                                   mi.Name, mi.GetParameters().Select(pi => pi.ParameterType).ToArray()) == null
                               : true));

            foreach (MethodInfo method in nonObsoleteMethods)
            {
                bool wrappedAsProperty = false;

                if (method.Name.Length > 3 && method.IsPublic)
                {
                    if (method.Name.StartsWith("get")
                        && method.ReturnType != typeof(void)
                        && method.GetParameters().Length == 0)
                    {
                        GetWrapperPropInfoFor(Properties, method.Name.Substring(3)).GetterMethod = method;
                        wrappedAsProperty = true;
                    }
                    else if (method.Name.StartsWith("set")
                             && method.GetParameters().Length == 1
                             && method.ReturnType == typeof(void))
                    {
                        GetWrapperPropInfoFor(Properties, method.Name.Substring(3)).SetterMethod = method;
                        wrappedAsProperty = true;
                    }
                }

                if (!wrappedAsProperty)
                    Methods.Add(method.ToString(), new WrapperMethodInfo(this, method));
            }

            if (!type.IsAbstract)
            {
                // Extract constructors
                var nonObsoletePublicConstructors = type
                    .GetConstructors()
                    .Where(mi => (mi.GetCustomAttributes(typeof(ObsoleteAttribute), true).Count() == 0))
                    .Where(mi => mi.DeclaringType == type)
                    .Where(mi => !mi.IsAbstract);

                foreach (var constructor in nonObsoletePublicConstructors)
                    Constructors.Add(new WrapperConstructorInfo(this, constructor));
            }

            // Extract public static

            var publicStaticFields = type
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(mi => (mi.GetCustomAttributes(typeof(ObsoleteAttribute), true).Count() == 0))
                .Where(f => !f.FieldType.IsInterface);

            foreach (var field in publicStaticFields)
                StaticPublicFields.Add(new WrapperStaticPublicField(this, field));
        }
    }
}