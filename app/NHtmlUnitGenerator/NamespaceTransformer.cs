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

namespace NHtmlUnit.Generator
{
    public class NamespaceTransformer
    {
        private static readonly string[] ignore;
        private static readonly IDictionary<string, string> map;
        private readonly string @namespace;


        static NamespaceTransformer()
        {
            ignore = new[]
            {
                "org", "com", "net", "gargoylesoftware", "sourceforge"
            };
            map = new Dictionary<string, string>
            {
                { "htmlunit", "HtmlUnit" },
                { "io", "IO" },
                { "xmlcommons", "Xml.Commons" },
                { "javascript", "JavaScript" },
                { "corejs", "CoreJS" },
            };
        }


        public NamespaceTransformer(string @namespace)
        {
            this.@namespace = @namespace;
        }


        public string Transform()
        {
            var segments = this.@namespace.Split('.').Select(Transform).Where(s => s != null);
            return String.Join(".", segments);
        }


        private static string Transform(string namespaceSegment)
        {
            if (ignore.Contains(namespaceSegment))
                return null;

            if (map.ContainsKey(namespaceSegment))
                return map[namespaceSegment];

            return namespaceSegment.InflectTo().Pascalized;
        }
    }
}