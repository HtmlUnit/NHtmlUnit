#region License

// --------------------------------------------------
// Copyright © 2003-2011 OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

using System.Linq;
using System.Reflection;
using System.Text;

namespace NHtmlUnit.Generator
{
    public class WrapperConstructorInfo : IWrapperMethodBase
    {
        private readonly WrapperClassInfo classInfo;
        private readonly ConstructorInfo targetConstructorInfo;


        public WrapperConstructorInfo(WrapperClassInfo classInfo, ConstructorInfo targetConstructorInfo)
        {
            this.targetConstructorInfo = targetConstructorInfo;
            this.classInfo = classInfo;
        }


        public WrapperClassInfo ClassInfo
        {
            get { return this.classInfo; }
        }

        public WrapperRepository Repository
        {
            get { return ClassInfo.Repository; }
        }

        public ConstructorInfo TargetConstructorInfo
        {
            get { return this.targetConstructorInfo; }
        }


        internal void GenerateConstructorCode(StringBuilder sb)
        {
            // Change from camelCase to UpperCamelCase

            string origName = TargetConstructorInfo.Name;
            string transformedName = ClassInfo.TargetNameWithoutNamespace;

            sb.AppendFormat("      public {0}(", transformedName);

            bool firstParameter = true;

            var parameters =
                TargetConstructorInfo.GetParameters().Select(pi => (new WrapperParameterInfo(this, pi))).ToArray();

            foreach (var mp in parameters)
            {
                if (Repository.TypeIsWrapped(mp.ParameterType))
                    Repository.MarkUsageOfType(mp.ParameterType);
            }
            
            foreach (var mp in parameters)
            {
                if (!firstParameter)
                    sb.Append(", ");
                firstParameter = false;

                sb.AppendFormat("{0} {1}", mp.ParameterTypeName, mp.ParameterName);
            }

            // Generate function call
            var functionCallSb = new StringBuilder();

            functionCallSb.Append("(");

            firstParameter = true;
            foreach (var mp in parameters)
            {
                if (!firstParameter)
                    functionCallSb.Append(", ");
                firstParameter = false;

                if (mp.IsWrapped)
                    functionCallSb.AppendFormat("({0}){1}.WrappedObject", ClassInfo.SanitizeTypeName(mp.ParameterType.FullName), mp.ParameterName);
                else
                    functionCallSb.Append(mp.ParameterName);
            }

            functionCallSb.Append(")");

            sb.AppendFormat(")\r\n         : this(new {0}{1}) {{}}\r\n\r\n", ClassInfo.WrappedTypeFullNameSanitized, functionCallSb);
        }
    }
}