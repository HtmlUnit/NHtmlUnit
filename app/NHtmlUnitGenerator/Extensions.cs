#region License

// --------------------------------------------------
// Copyright © 2003-2011 OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

using System.Linq;

using Mono.Cecil;

namespace NHtmlUnit.Generator
{
    public static class Extensions
    {
        public static bool IsImplementationOf(this MethodDefinition method, TypeDefinition @interface)
        {
            return @interface.Methods.Any(i => Matches(i, method));
        }


        private static bool Matches(MethodDefinition interfaceMethod, MethodDefinition typeMethod)
        {
            if (interfaceMethod.Name != typeMethod.Name)
                return false;

            if (!interfaceMethod.HasParameters && !typeMethod.HasParameters)
                return true;

            if (interfaceMethod.Parameters.Count != typeMethod.Parameters.Count)
                return false;

            for (int i = 0; i < interfaceMethod.Parameters.Count; i++)
            {
                var interfaceParameter = interfaceMethod.Parameters[i];
                var typeParameter = typeMethod.Parameters[i];

                if (interfaceParameter.Name != typeParameter.Name)
                    return false;

                if (interfaceParameter.ParameterType != typeParameter.ParameterType)
                    return false;
            }

            return true;
        }
    }
}