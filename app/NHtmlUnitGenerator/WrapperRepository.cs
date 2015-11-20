#region License

// --------------------------------------------------
// Copyright © OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;

using com.gargoylesoftware.htmlunit;

using ikvm.runtime;

using java.lang;
using java.lang.reflect;
using java.util;

using org.w3c.dom;

using sun.reflect.generics.reflectiveObjects;

using Exception = System.Exception;
using NotImplementedException = System.NotImplementedException;
using Object = System.Object;
using Random = System.Random;
using String = System.String;
using StringBuilder = System.Text.StringBuilder;
using Type = System.Type;

namespace NHtmlUnit.Generator
{
    public class WrapperRepository
    {
        private readonly Dictionary<string, string> translations;
        private bool stopAskingForListTypesOnConsole;


        public WrapperRepository(Assembly targetAssembly)
        {
            this.translations = new Dictionary<string, string>
            {
                { "com.gargoylesoftware.htmlunit.", "" },
                { "org.w3c.dom.", "W3C.Dom." },
                { "com.gargoylesoftware.htmlunit.javascript.host.event.", "Javascript.Host.Events." }
            };

            Settings.Default.Whaat = new Random().Next().ToString(CultureInfo.InvariantCulture);
            Settings.Default.Save();

            UsedTypes = new HashSet<Type>();
            CompleteTypes = new Dictionary<Type, WrapperClassInfo>();
            TargetAssembly = targetAssembly;

            if (Settings.Default.ListTypes != null)
            {
                ListTypes =
                    Settings.Default.ListTypes.Cast<string>()
                        .Where(s => s.Contains(':'))
                        .ToDictionary(
                            s => s.Substring(0, s.IndexOf(':')),
                            s => s.Substring(s.IndexOf(':') + 1));
            }
            else
            {
                ListTypes = new Dictionary<string, string>();
                Settings.Default.ListTypes = new StringCollection();
            }
        }


        public Dictionary<Type, WrapperClassInfo> CompleteTypes { get; private set; }
        public Dictionary<string, string> ListTypes { get; private set; }

        //public string SourceNamespace
        //{
        //   get { return "com.gargoylesoftware.htmlunit"; }
        //}

        public Assembly TargetAssembly { get; private set; }

        public string TargetDirectory
        {
            get { return @"..\..\..\NHtmlUnit"; }
        }

        public Dictionary<string, string> Translations
        {
            get { return this.translations; }
        }

        public HashSet<Type> UsedTypes { get; private set; }

        public string WrapperNamespace
        {
            get { return "NHtmlUnit"; }
        }

        /// <summary>
        /// Will only write out files if actually set to true
        /// </summary>
        /// <value>
        ///   <c>true</c> if [dry run enabled]; otherwise, <c>false</c>.
        /// </value>
        internal bool FileOutputEnabled
        {
            get { return true; }
        }


        public static ListTypeMapEntry GetValidMapping(Type targetType)
        {
            var mappings = new[]
            {
                //new ListTypeMapEntry(targetType, typeof(System.Array), "IList", "ListWrapper", "ShallowListWrapper"),
                new ListTypeMapEntry(targetType, typeof(List), "IList", "ListWrapper", "ShallowListWrapper"),
                new ListTypeMapEntry(
                    targetType, typeof(Collection), "ICollection", "CollectionWrapper", "ShallowCollectionWrapper"),
                new ListTypeMapEntry(
                    targetType, typeof(Iterable), "IEnumerable", "IterableWrapper", "ShallowIterableWrapper"),
                new ListTypeMapEntry(
                    targetType, typeof(NodeList), "IList", "NodeListWrapper", "SHALLOW NODELIST NOT SUPPORTED!")
                //new ListTypeMapEntry(
                //    targetType, typeof(Map), "IDictionary", "MapWrapper", "ShallowMapWrapper"),
            };

            return mappings.FirstOrDefault(m => m.IsValidMapping);
        }


        public string EncodeListType(Type wrappedType)
        {
            return "ListWrapper<" + GetWrapperClassName(wrappedType) + ">";
        }


        public void GenerateAssemblyInfo()
        {
            const string assemblyInfoTemplatePath = @"..\..\Templates\GlobalAssemblyInfo.cs.template";
            const string assemblyInfoPath = @"..\..\..\GlobalAssemblyInfo.cs";
            string template = File.ReadAllText(assemblyInfoTemplatePath);

            Assembly htmlUnitAssembly = Assembly.GetAssembly(typeof(WebClient));
            string htmlUnitVersion = htmlUnitAssembly.GetName().Version.ToString();

            string assemblyInfo = string.Format(template, DateTime.Now.Year, htmlUnitVersion);

            File.WriteAllText(assemblyInfoPath, assemblyInfo);
        }


        public bool GenerateForAllUsedIncomplete()
        {
            var allAssemblyTypes = new Dictionary<string, Type>();

            foreach (Type t in TargetAssembly.GetTypes().Where(t => t.IsPublic))
            {
                if (!allAssemblyTypes.ContainsKey(t.Name))
                    allAssemblyTypes.Add(t.Name, t);
            }

            bool added = false;

            foreach (Type type in UsedTypes.ToArray())
            {
                if (!TypeIsWrapped(type))
                    throw new InvalidOperationException();

                if (!CompleteTypes.ContainsKey(type))
                {
                    var wci = new WrapperClassInfo(type, this);
                    CompleteTypes.Add(type, wci);

                    foreach (
                        Type inheritedType in
                            allAssemblyTypes.Values.Where(t => t.IsSubclassOf(wci.WrappedType) && t.IsPublic)
                                .Where(TypeIsWrapped))
                    {
                        if (!inheritedType.GetCustomAttributes(typeof(ObsoleteAttribute), true).Any()
                            && !UsedTypes.Contains(inheritedType))
                            UsedTypes.Add(inheritedType);
                    }

                    var sb = new StringBuilder();

                    if (wci.IsInterface)
                        wci.GenerateInterfaceCode(sb);
                    else
                        wci.GenerateClassCode(sb);

                    if (wci.FilePathBase.IndexOfAny(new[] { '\\', '/' }) != -1)
                        Directory.CreateDirectory(Path.GetDirectoryName(wci.FilePathBase));

                    WriteTextToFile(wci.FilePathBase + ".cs", sb.ToString(), true);

                    wci.GenerateUserClassFile();

                    added = true;
                }
            }

            return added;
        }


        public void GenerateNuspec()
        {
            const string nuspecTemplatePath = @"..\..\Templates\NHtmlUnit.nuspec.template";
            const string nuspecPath = @"..\..\..\..\NHtmlUnit.nuspec";
            string template = File.ReadAllText(nuspecTemplatePath);

            Assembly htmlUnitAssembly = Assembly.GetAssembly(typeof(WebClient));
            string htmlUnitVersion = htmlUnitAssembly.GetName().Version.ToString();

            string assemblyInfo = string.Format(template, DateTime.Now.Year, htmlUnitVersion);

            File.WriteAllText(nuspecPath, assemblyInfo);
        }


        public void GenerateUntilDone(params Type[] rootTypes)
        {
            foreach (Type t in rootTypes)
            {
                if (!UsedTypes.Contains(t))
                    UsedTypes.Add(t);
            }

            while (GenerateForAllUsedIncomplete())
            {
            }
        }


        public Type GetListTypeFor(WrapperPropInfo wpi)
        {
            if (wpi.PropertyType.IsArray)
                return wpi.PropertyType.DeclaringType;
            string fullPropName = wpi.FullNameDest;

            Type listType = LoadListTypeForProperty(fullPropName);

            if (listType != null)
                return listType;

            // Try to find type from get*BySomething))
            if (fullPropName.EndsWith("s"))
            {
                string singularName = wpi.Name.Substring(0, wpi.Name.Length - 1);

                string singularGetNameStart = "get" + singularName + "By";

                Type guessedReturnType = wpi.ClassInfo.WrappedType
                    .GetMethods(BindingFlags.Instance | BindingFlags.Public)
                    .Where(mi => mi.ReturnType != typeof(void))
                    .Where(mi => mi.Name.StartsWith(singularGetNameStart))
                    .Where(mi => mi.Name.Length > singularGetNameStart.Length)
                    .Select(mi => mi.ReturnType)
                    .FirstOrDefault() ?? TargetAssembly.GetTypes()
                        .FirstOrDefault(t => t.Name == "Html" + singularName || t.Name == singularName);

                if (guessedReturnType != null)
                {
                    Console.WriteLine("Guessed list type " + guessedReturnType.FullName + " for " + fullPropName);
                    return guessedReturnType;
                }
            }

            listType = GetListTypeFor(fullPropName);

            return listType;
        }


        public Type GetMethodReturnListType(MethodInfo methodInfo)
        {
            if (typeof(NodeList).IsAssignableFrom(methodInfo.ReturnType))
                return typeof(Node);

            var genericsParameters = GetGenericsParametersForReturnType(methodInfo);

            if (genericsParameters.Length != 1)
                return typeof(Object);

            return genericsParameters[0];
        }


        public string GetWrapperClassName(Type wrappedType)
        {
            throw new NotImplementedException();
        }


        public void WriteTextToFile(string path, string text, bool overwriteExistingFile)
        {
            FileInfo file = new FileInfo(path);

            if (!file.Directory.Exists)
                file.Directory.Create();

            if (FileOutputEnabled)
            {
                if (overwriteExistingFile || !File.Exists(path))
                    File.WriteAllText(path, text);
            }
            else
            {
                Console.WriteLine("START: " + path + " (not writing to file)");
                Console.WriteLine(text);
                Console.WriteLine("STOP: " + path);
            }
        }


        internal string GetRelativeClassName(WrapperClassInfo wci)
        {
            if (!TypeIsWrapped(wci.WrappedType))
                throw new InvalidOperationException();

            return GetRelativeClassName(wci.WrappedType);
        }


        internal string GetRelativeClassName(Type sourceType)
        {
            if (!TypeIsWrapped(sourceType))
                throw new InvalidOperationException();

            return GetRelativeClassName(sourceType.FullName, sourceType.IsInterface);
        }


        internal string GetTargetFullName(WrapperClassInfo wrapperClassInfo)
        {
            return WrapperNamespace + "." + wrapperClassInfo.RelativeClassName;
        }


        internal string GetTargetFullName(Type t)
        {
            return WrapperNamespace + "." + GetRelativeClassName(t);
        }


        internal void MarkUsageOfType(Type listType)
        {
            if (listType.FullName.StartsWith("net.sourceforge"))
                throw new NotImplementedException();

            if (!TypeIsWrapped(listType))
                throw new InvalidOperationException();

            string listTypeName = listType.Name;

            if (listTypeName.EndsWith("[]"))
                return;

            if (listTypeName == "Map" || listTypeName == "Set" || listTypeName == "URL"
                || listTypeName.StartsWith("LIST_TYPE_OF_") || listTypeName == "CellIterator")
                return;

            if (!UsedTypes.Contains(listType))
                UsedTypes.Add(listType);
        }


        internal string TranslateToNativeTypeName(Type type)
        {
            switch (type.FullName)
            {
                case "System.Void":
                    return "void";
                case "System.Int32":
                    return "int";
                case "System.String":
                    return "string";
                case "System.Boolean":
                    return "bool";
                case "System.Object":
                    return "object";

                default:
                    return null;
            }
        }


        internal bool TypeIsWrapped(Type type)
        {
            if (type == typeof(NodeList))
                Console.WriteLine("BREAK!!");

            if (type == typeof(Map))
                Console.WriteLine("BREAK!!");

            if (type == null)
                throw new ArgumentNullException("type");

            if (type.FullName == null)
                throw new ArgumentException("type");

            bool translationOk = Translations.Any(trans => type.FullName.StartsWith(trans.Key));

            return /* type.Assembly == TargetAssembly && */ translationOk
                                                            && !type.IsNested /* && !type.IsInterface */&& !type.IsArray;
        }


        /// <summary>
        /// Helper function that gets the corresponding Java Method class for MethodInfo
        /// </summary>
        /// <param name="methodInfo">The method info.</param>
        /// <returns></returns>
        private static Method GetJavaMethod(MethodInfo methodInfo)
        {
            var javaClass = Util.getFriendlyClassFromType(methodInfo.DeclaringType);
            Method javaMethod = null;

            try
            {
                if (javaClass != null)
                {
                    var matchingMethods = javaClass.getMethods()
                        .Where(m => m.getName() == methodInfo.Name &&
                                    m.getReturnType() == (Class)methodInfo.ReturnType &&
                                    m.getParameterTypes().SequenceEqual(
                                        methodInfo.GetParameters().Select(pi => (Class)pi.ParameterType)))
                        .ToArray();

                    if (matchingMethods.Length > 1)
                    {
                        throw new NotImplementedException(
                            "Found multiple Method matches for MethodInfo, filtering not strict enough!");
                    }

                    javaMethod = matchingMethods.FirstOrDefault();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            return javaMethod;
        }


        private Type GetDotNetType(java.lang.reflect.Type javaType)
        {
            // ikvm.runtime.Util.getInstanceTypeFromClass(ta)
            Type returnedType = null;

            if (javaType is WildcardTypeImpl ||
                javaType is TypeVariableImpl ||
                javaType is ParameterizedTypeImpl)
            {
                // Wildcard <?> parameter, this means the method itself is generic.
                // We don't know how to handle this yet, so just return object. ???
                returnedType = typeof(object);
            }
            else if (javaType is Class)
                returnedType = Util.getInstanceTypeFromClass(javaType as Class);
            else
                throw new NotImplementedException("Don't know how to convert this java Type to .NET Type");

            return returnedType;
        }


        private Type[] GetGenericsParametersForReturnType(MethodInfo methodInfo)
        {
            var javaMethod = GetJavaMethod(methodInfo);

            if (javaMethod == null)
                throw new InvalidOperationException("Unable to convert .NET MethodInfo to Java Method reflection type");

            var parameterizedType = javaMethod.getGenericReturnType() as ParameterizedType;

            // No generic return type maybe?
            if (parameterizedType == null)
                return new Type[] { };

            var atp = parameterizedType.getActualTypeArguments();

            var typeParameters = parameterizedType.getActualTypeArguments()
                .Select(jt => GetDotNetType(jt))
                .ToArray();

            return typeParameters;
        }


        private Type GetListTypeFor(string fullMemberName)
        {
            Type listType = null;

            string listTypeName;
            if (!this.stopAskingForListTypesOnConsole)
            {
                Console.WriteLine("No type for List " + fullMemberName + " found, type in:");
                listTypeName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(listTypeName))
                {
                    if (listTypeName.Contains("STOP"))
                        this.stopAskingForListTypesOnConsole = true;
                    else if (!string.IsNullOrWhiteSpace(listTypeName))
                    {
                        listType = GetTypeFromTypeFullName(listTypeName);

                        if (listType != null)
                        {
                            // var confString = fullMemberName + ":" + listType.FullName;
                            Settings.Default.ListTypes.Add(fullMemberName + ":" + listType.FullName);
                            Settings.Default.Save();
                        }
                    }
                }
            }
            return listType;
        }


        private string GetRelativeClassName(string sourceTypeName, bool isInterface)
        {
            string relativeClassName = null;

            foreach (var trans in this.translations)
            {
                if (sourceTypeName.StartsWith(trans.Key))
                    relativeClassName = trans.Value + sourceTypeName.Substring(trans.Key.Length);
            }

            if (isInterface)
            {
                relativeClassName = relativeClassName == null
                    ? "I"
                    : relativeClassName.Insert(relativeClassName.LastIndexOf('.') + 1, "I");
            }

            if (relativeClassName == null)
                throw new InvalidOperationException("No translation found for namespace for " + sourceTypeName);

            string[] names = relativeClassName.Split('.')
                .Select(x => String.Concat(x.Substring(0, 1).ToUpper(), x.Substring(1)))
                .ToArray();

            relativeClassName = String.Join(".", names);

            return relativeClassName;
        }


        private Type GetTypeFromTypeFullName(string typeFullName)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .Select(asm => asm.GetType(typeFullName))
                .Where(t => t != null)
                .FirstOrDefault();
        }


        private Type LoadListTypeForProperty(string fullPropName)
        {
            string listTypeName;
            Type listType = null;

            if (ListTypes.TryGetValue(fullPropName, out listTypeName))
            {
                listType = AppDomain.CurrentDomain.GetAssemblies().Select((asm) => (asm.GetType(listTypeName)))
                    .Where(t => t != null).FirstOrDefault();

                if (listType == null)
                    Console.WriteLine("Warning: Unable to load type " + listTypeName);
            }

            return listType;
        }
    }
}