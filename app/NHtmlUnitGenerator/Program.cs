#region License

// --------------------------------------------------
// Copyright © 2003-2011 OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

using System;

using com.gargoylesoftware.htmlunit;

using Mono.Cecil;

namespace NHtmlUnit.Generator
{
    internal static class Program
    {
        private static void Main(string[] args)
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
            ReaderParameters parameters = new ReaderParameters(ReadingMode.Immediate);

            string fileName = typeof(WebClient).Assembly.Location;

            Console.WriteLine("Reading {0}.", fileName);

            AssemblyDefinition htmlUnitAssembly =
                AssemblyDefinition.ReadAssembly(fileName, parameters);
        }
    }
}