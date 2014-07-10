#region License

// --------------------------------------------------
// Copyright © 2003-2011 OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

using System;

namespace NHtmlUnit.Generator
{
    public class ListTypeMapEntry
    {
        private readonly Type fromType;
        private readonly string fullWrapperName;
        private readonly string shallowWrapperName;
        private readonly Type targetType;
        private readonly string toTypeName;


        public ListTypeMapEntry(Type targetType,
                                Type fromType,
                                string toTypeName,
                                string fullWrapperName,
                                string shallowWrapperName)
        {
            this.targetType = targetType;
            this.fromType = fromType;
            this.toTypeName = toTypeName;
            this.fullWrapperName = fullWrapperName;
            this.shallowWrapperName = shallowWrapperName;
        }


        public Type FromType
        {
            get { return this.fromType; }
        }

        public string FullWrapperName
        {
            get { return this.fullWrapperName; }
        }

        public bool IsValidMapping
        {
            get { return FromType.IsAssignableFrom(TargetType); }
        }

        public string ShallowWrapperName
        {
            get { return this.shallowWrapperName; }
        }

        public Type TargetType
        {
            get { return this.targetType; }
        }

        public string ToTypeName
        {
            get { return this.toTypeName; }
        }
    }
}