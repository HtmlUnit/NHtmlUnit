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
using System.Linq;

using com.gargoylesoftware.htmlunit;

using Mono.Cecil;

namespace NHtmlUnit.Generator
{
    internal static class Program
    {
        private static void Main()
        {
            try
            {
                Transform();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }


        private static void Transform()
        {
            string fileName = typeof(WebClient).Assembly.Location;

            Console.WriteLine("Reading {0}.", fileName);

            AssemblyDefinition htmlUnitAssembly = AssemblyDefinition.ReadAssembly(fileName);

            var publicTypes = htmlUnitAssembly.MainModule.Types.Where(t => t.IsPublic);

            foreach (var type in publicTypes)
            {
                NamespaceTransformer namespaceTransformer = new NamespaceTransformer(type.Namespace);
                type.Namespace = namespaceTransformer.Transform();

                if (type.IsInterface)
                    type.Name = String.Concat('I', type.Name);

                if (type.HasInterfaces)
                {
                    foreach (var @interface in type.Interfaces.Select(x => x.Resolve()))
                    {
                        foreach (var interfaceMethod in @interface.Methods)
                        {
                            var typeMethod = type.Methods.FirstOrDefault(x => x.Name == interfaceMethod.Name);
                            
                            // var explicitMethod = new MethodDefinition("")
                        }
                    }
                }

            }

            htmlUnitAssembly.Write("NHtmlUnit.dll");
            PeVerifier verifier = new PeVerifier();

            string v;
            verifier.Verify("NHtmlUnit.dll", out v);
            Console.WriteLine(v);
        }

    }
}