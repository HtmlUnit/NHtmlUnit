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

            foreach (var type in htmlUnitAssembly.MainModule.Types.Where(t => t.IsPublic))
            {
                var segments = type.Namespace.Split('.').Select(TransformNamespaceSegment).Where(s => s != null);
                type.Namespace = String.Join(".", segments);

                if (type.IsInterface)
                    type.Name = String.Concat('I', type.Name);
            }

            htmlUnitAssembly.Write("NHtmlUnit.dll");
            PeVerifier verifier = new PeVerifier();

            string v;
            verifier.Verify("NHtmlUnit.dll", out v);
            Console.WriteLine(v);
        }


        private static string TransformNamespaceSegment(string namespaceSegment)
        {
            string[] ignore = new[]
            {
                "org", "com", "net", "gargoylesoftware", "sourceforge"
            };

            if (ignore.Contains(namespaceSegment))
                return null;

            IDictionary<string, string> map = new Dictionary<string, string>
            {
                { "htmlunit", "HtmlUnit" },
                { "io", "IO" },
                { "xmlcommons", "Xml.Commons" },
                { "javascript", "JavaScript" },
                { "corejs", "CoreJS" },
            };

            if (map.ContainsKey(namespaceSegment))
                return map[namespaceSegment];

            return namespaceSegment.InflectTo().Pascalized;
        }
    }
}