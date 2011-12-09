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

namespace NHtmlUnit.Html
{
    public partial class HtmlElement
    {
        public TPage Click<TPage>()
            where TPage : IPage
        {
            return (TPage)Click();
        }


        public HtmlElement GetElementByClassName(string className)
        {
            return GetByXPath(String.Format("//*[contains(@class, '{0}')]", className))
                .OfType<HtmlElement>()
                .FirstOrDefault(e =>
                                e.GetAttribute("class")
                                    .Split(" \r\n\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                    .Contains(className));
        }


        /// <summary>
        /// Searches for an element with specified name and type T, and makes sure that its unique.
        /// Throws an exception if no matching element or multiple elements with same name is found.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public HtmlElement GetElementByName(string name)
        {
            return GetByXPath(String.Format("//*[@name='{0}')]", name))
                .OfType<HtmlElement>()
                .FirstOrDefault();
        }
    }
}