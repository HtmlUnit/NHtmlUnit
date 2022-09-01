#region License

// --------------------------------------------------
// Copyright © 2003-2011 OKB. All Rights Reserved.
//
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using com.gargoylesoftware.htmlunit;
using com.gargoylesoftware.htmlunit.html;

namespace NHtmlUnit.Generator
{
    internal class Program
    {
        private static Dictionary<string, Type> CreateTypeList(
            IEnumerable<Assembly> assemblies, IEnumerable<Type> types)
        {
            var dict = new Dictionary<string, Type>();

            foreach (Type t in types)
            {
                IEnumerable<Type> superTypes =
                    assemblies.SelectMany(a => a.GetTypes()).Where(x => x.IsSubclassOf(t) && x.IsPublic);

                foreach (Type st in superTypes.Concat(new[] { t }))
                {
                    if (!dict.ContainsKey(st.Name))
                        dict[st.Name] = st;
                }
            }

            return dict;
        }

        private static void GenerateWrapper()
        {
          Type webClientType = typeof(WebClient);
            var wrapperRep = new WrapperRepository(typeof(HtmlPage).Assembly);
            //GetJavaPropsFromType(webClientType);
            //GetJavaPropsFromType(typeof(HtmlPage));
            //GetJavaPropsFromType(typeof(HtmlInput));

            wrapperRep.GenerateUntilDone(typeof(DomNode), typeof(WebClient), typeof(HtmlPage), typeof(CollectingAlertHandler));

            wrapperRep.GenerateAssemblyInfo();
            wrapperRep.GenerateNuspec();
            //var classInfoList = CreateTypeList(
            //   new[] { typeof(HtmlPage).Assembly },
            //   new[]
            //   {
            //      typeof(HtmlPage),
            //      typeof(SgmlPage)
            //   }).Select(t => new WrapperClassInfo(t.Value, wrapperRep))
            //   .ToArray()
            //   .Select((ci => ci.GenerateClassCode(new StringBuilder()).ToString()));

            //foreach (var src in classInfoList)
            //   Console.WriteLine(src);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Done! Press any key to exit.");

            Console.ReadKey();
        }


        private static void Main(string[] args)
        {
            // Console.WriteLine("App config path: " + Settings.Default);

            try
            {
                GenerateWrapper();
            }
            catch (FileNotFoundException e)
            {
                Console.Error.WriteLine("ERROR!");
                Console.Error.WriteLine("ERROR! Fusion Log:");
                Console.Error.WriteLine(e.FusionLog);
                Console.Error.WriteLine("ERROR!");
                Console.Error.WriteLine("ERROR! Inner Exception:");
                Console.Error.WriteLine(e.InnerException);
                Console.Error.WriteLine("ERROR!");
                Console.Error.WriteLine("ERROR! FileNotFoundException:");
                Console.Error.WriteLine(e);
                throw;
            }
        }
    }
}
