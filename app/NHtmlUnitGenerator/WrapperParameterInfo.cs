#region License

// --------------------------------------------------
// Copyright © 2003-2011 OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

using System;
using System.Linq;
using System.Reflection;

namespace NHtmlUnit.Generator
{
    public class WrapperParameterInfo
    {
        private readonly IWrapperMethodBase methodInfo;
        private readonly ParameterInfo wrappedParameterInfo;


        public WrapperParameterInfo(IWrapperMethodBase methodInfo, ParameterInfo wrappedParameterInfo)
        {
            this.methodInfo = methodInfo;
            this.wrappedParameterInfo = wrappedParameterInfo;
        }


        public WrapperClassInfo ClassInfo
        {
            get { return MethodInfo.ClassInfo; }
        }

        public bool IsWrapped
        {
            get { return Repository.TypeIsWrapped(ParameterType); }
        }

        public IWrapperMethodBase MethodInfo
        {
            get { return this.methodInfo; }
        }

        public string ParameterName
        {
            get
            {
                // Check for reserved keywords
                var name = WrappedParameterInfo.Name;
                if (string.IsNullOrWhiteSpace(name))
                    name = "arg" + WrappedParameterInfo.Position;
                else
                {
                    if (ClassInfo.ReservedKeywords.Contains(name))
                        name += "Arg";
                }

                return name;
            }
        }

        public Type ParameterType
        {
            get { return WrappedParameterInfo.ParameterType; }
        }

        public string ParameterTypeName
        {
            get
            {
                if (IsWrapped)
                    return Repository.GetTargetFullName(ParameterType);
                else
                {
                    string nativeTypeName = Repository.TranslateToNativeTypeName(ParameterType);

                    if (!string.IsNullOrEmpty(nativeTypeName))
                        return nativeTypeName;

                    return ParameterType.FullName;
                }
            }
        }

        public WrapperRepository Repository
        {
            get { return MethodInfo.Repository; }
        }

        public ParameterInfo WrappedParameterInfo
        {
            get { return this.wrappedParameterInfo; }
        }
    }
}