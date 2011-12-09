#region License

// --------------------------------------------------
// Copyright © 2003-2011 OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

using System;
using System.Reflection;
using System.Text;

namespace NHtmlUnit.Generator
{
    public class WrapperPropInfo
    {
        private readonly WrapperClassInfo classInfo;
        private readonly WrapperRepository repository;


        public WrapperPropInfo(WrapperClassInfo wci, string propName, WrapperRepository wrapperRepository)
        {
            Name = propName;
            this.classInfo = wci;
            this.repository = wrapperRepository;
        }


        public WrapperClassInfo ClassInfo
        {
            get { return this.classInfo; }
        }

        public string FullNameDest
        {
            get { return ClassInfo.WrappedType + "." + Name; }
        }

        public MethodInfo GetterMethod { get; set; }

        public string GetterName
        {
            get { return "get" + Name; }
        }

        public bool IsReadOnly
        {
            get { return SetterMethod == null; }
        }

        public string Name { get; private set; }

        public Type PropertyType
        {
            get { return GetterMethod.ReturnType; }
        }

        public WrapperRepository Repository
        {
            get { return this.repository; }
        }

        public MethodInfo SetterMethod { get; set; }

        public string SetterName
        {
            get { return IsReadOnly ? null : "set" + Name; }
        }

        public string UnwrappedPropertyNameCsharp
        {
            get
            {
                string nativeCsharpName = Repository.TranslateToNativeTypeName(PropertyType);

                if (!string.IsNullOrEmpty(nativeCsharpName))
                    return nativeCsharpName;

                switch (PropertyType.Name)
                {
                    case "Int32":
                        return "int";
                    case "String":
                        return "string";
                    case "Boolean":
                        return "bool";

                    default:
                        break;
                }

                if (ClassInfo.HasNamespaceEntryForType(PropertyType))
                    return PropertyType.Name;

                return PropertyType.FullName.Replace("+", ".");
                // Inner classes in C# is written with . but reflection type string uses +
            }
        }

        public string WrappedPropertyTypeNameCsharp
        {
            get
            {
                Type type = PropertyType;

                //if (PropertyType.Name == "SgmlPage")
                //{
                //   var ifs = ClassInfo.WrappedType
                //      .GetInterfaces();

                //   var pageInterfacePropInfo =
                //      ClassInfo.WrappedType
                //         .GetInterfaces()
                //         .Where(i => Repository.TypeIsWrapped(i))
                //         .SelectMany(il => il.GetProperties())
                //         .Where(pi => pi.Name == "Page")
                //         .ToArray();

                //   throw new NotImplementedException();
                //}

                //// Hack, find equivalent property of interface
                //var interfacePropInfo =
                //   ClassInfo.WrappedType
                //      .GetInterfaces()
                //      .Where(i => Repository.TypeIsWrapped(i))
                //      .SelectMany(il => il.GetProperties())
                //      .Where(pi => pi.Name == PropertyType.Name)
                //      .Where(pi => pi.PropertyType.IsAssignableFrom(PropertyType))
                //      .Where(pi => pi.PropertyType != PropertyType)
                //      .FirstOrDefault();

                //if (interfacePropInfo != null)
                //{
                //   Console.WriteLine("Found different interface prop with same name..");
                //}

                return Repository.GetTargetFullName(type);
            }
        }


        public void GeneratePropertyCode(StringBuilder sb)
        {
            if (PropertyType.IsNested)
            {
                Console.WriteLine("TODO: Support for nested class: " + PropertyType.FullName);
                return;
            }

            var targetType = PropertyType;

            var validMapping = WrapperRepository.GetValidMapping(targetType);

            string getBody = string.Empty;

            if (validMapping != null)
            {
                Type collectionType = Repository.GetMethodReturnListType(GetterMethod);

                if (collectionType == null)
                    Console.WriteLine("TODO: Recognize collection " + FullNameDest);
                else if (collectionType.IsNested)
                    Console.WriteLine("TODO: Support for nested class: " + collectionType.FullName);
                else
                {
                    if (SetterMethod != null)
                        Console.WriteLine("TODO: Can't generate setter wrapper for wrapped collection " + FullNameDest);

                    if (Repository.TypeIsWrapped(collectionType))
                        Repository.MarkUsageOfType(collectionType);

                    string collectionTypeName = Repository.TypeIsWrapped(collectionType)
                                                    ? Repository.GetTargetFullName(collectionType)
                                                    : collectionType.FullName;

                    if (ClassInfo.IsInterface)
                    {
                        sb.AppendFormat(
                            "      {0}<{1}> {2} {{ get; }}\r\n", validMapping.ToTypeName, collectionTypeName, Name);
                    }
                    else
                    {
                        getBody =
                            @"
      public {0}<{1}> {2}
      {{
         get
         {{
            return new {3}<{1}>(
               WObj.{4}());
         }}
       }}
";

                        sb.AppendFormat(
                            getBody,
                            /* {0} */ validMapping.ToTypeName,
                            /* {1} */ collectionTypeName,
                            /* {2} */ Name,
                            /* {3} */ Repository.TypeIsWrapped(collectionType)
                                          ? validMapping.FullWrapperName
                                          : validMapping.ShallowWrapperName,
                            /* {4} */ GetterMethod.Name);
                    }
                }
            }
            else
            {
                var propTypeIsWrapped = Repository.TypeIsWrapped(PropertyType);

                if (propTypeIsWrapped)
                    Repository.MarkUsageOfType(PropertyType);

                string typeName = propTypeIsWrapped
                                      ? Repository.GetTargetFullName(PropertyType)
                                      : PropertyType.FullName;

                if (ClassInfo.IsInterface)
                {
                    string propBody =
                        SetterMethod != null
                            ? "{ get; set; }"
                            : " { get; }";

                    sb.AppendFormat("      {0} {1} {2}\r\n", typeName, Name, propBody);
                }
                else
                {
                    if (!propTypeIsWrapped)
                    {
                        var setterBodyTemplate =
                            @"
         set
         {{
            WObj.{0}(value);
         }}
";

                        var propBodyTemplate =
                            @"
      public {0} {1}
      {{
         get
         {{
            return WObj.{2}();
         }}{3}
      }}
";

                        sb.AppendFormat(
                            propBodyTemplate,
                            /* {0} */ typeName,
                            /* {1} */ Name,
                            /* {2} */ GetterMethod.Name,
                            /* {3} */ SetterMethod != null
                                          ? string.Format(setterBodyTemplate, SetterMethod.Name)
                                          : string.Empty);
                    }
                    else
                    {
                        var setterBodyTemplate =
                            @"
         set
         {{
            WObj.{0}(({1})value.WrappedObject);
         }}
";

                        var propBodyTemplate =
                            @"
      public {0} {1}
      {{
         get
         {{
            return ObjectWrapper.CreateWrapper<{0}>(
               WObj.{2}());
         }}{3}
      }}

";

                        sb.AppendFormat(
                            propBodyTemplate,
                            /* {0} */ typeName,
                            /* {1} */ Name,
                            /* {2} */ GetterMethod.Name,
                            /* {3} */ SetterMethod != null
                                          ? string.Format(setterBodyTemplate, SetterMethod.Name, PropertyType.FullName)
                                          : string.Empty);
                    }
                }
            }
        }
    }
}