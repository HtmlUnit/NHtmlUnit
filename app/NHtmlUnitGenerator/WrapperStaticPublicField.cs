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
    public class WrapperStaticPublicField
    {
        private readonly WrapperClassInfo classInfo;
        private readonly FieldInfo targetFieldInfo;


        public WrapperStaticPublicField(WrapperClassInfo wrapperClassInfo, FieldInfo targetFieldInfo)
        {
            this.targetFieldInfo = targetFieldInfo;
            this.classInfo = wrapperClassInfo;
        }


        public WrapperClassInfo ClassInfo
        {
            get { return this.classInfo; }
        }

        public WrapperRepository Repository
        {
            get { return ClassInfo.Repository; }
        }

        public FieldInfo TargetFieldInfo
        {
            get { return this.targetFieldInfo; }
        }


        public void GenerateStaticFieldWrapper(StringBuilder sb)
        {
            var str =
                @"
      public static {0} {1}
      {{
         get
         {{
            return ObjectWrapper.CreateWrapper<{0}>(
               {2}.{1});
         }}
      }}

";

            if (Repository.TypeIsWrapped(TargetFieldInfo.FieldType))
            {
                sb.AppendFormat(
                    str,
                    Repository.GetTargetFullName(TargetFieldInfo.FieldType),
                    TargetFieldInfo.Name,
                    TargetFieldInfo.FieldType.FullName);
            }
            else
                Console.WriteLine(
                    "TODO: Implement static public field wrapper for non-wrapped types: " + TargetFieldInfo.Name);
        }
    }
}