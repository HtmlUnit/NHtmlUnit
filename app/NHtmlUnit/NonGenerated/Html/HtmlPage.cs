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

namespace NHtmlUnit.Html
{
    public partial class HtmlPage
    {
        public new Uri Url
        {
            get { return new Uri(base.Url.toString()); }
        }


        public HtmlElement GetElementByClassName(string className)
        {
            return GetByXPath(String.Format("//*[contains(@class,'{0}')]", className))
                .OfType<HtmlElement>()
                .FirstOrDefault(e =>
                                e.GetAttribute("class")
                                    .Split(" \r\n\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                    .Contains(className));
        }


        /// <summary>
        /// Searches for an element with specified id and type T, and makes sure that its unique.
        /// Throws an exception if no matching element or multiple elements with same id is found.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public new HtmlElement GetElementById(string id)
        {
            return base.GetElementById(id) as HtmlElement;
        }


        public THtmlElement GetElementById<THtmlElement>(string id)
            where THtmlElement : HtmlElement
        {
            return base.GetElementById(id) as THtmlElement;
        }


        /// <summary>
        /// Searches for an element with specified name and type T, and makes sure that its unique.
        /// Throws an exception if no matching element or multiple elements with same name is found.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public T GetElementByName<T>(string name) where T : HtmlElement
        {
            IList<DomElement> elements = GetElementsByName(name);

            if (elements.Count == 0)
                throw new HtmlElementNotFoundException("Could not find element with name " + name);

            T[] elementsCastToType = elements.OfType<T>().ToArray();

            if (elementsCastToType.Length == 0)
            {
                throw new HtmlElementNotFoundException("Element with name " + name + " was not of requested type "
                                                       + typeof(T).Name);
            }

            if (elementsCastToType.Length > 1)
            {
                throw new HtmlElementNotFoundException("Wanted one uniqe element with name " + name
                                                       + ", but found multiple.");
            }

            return elementsCastToType[0];
        }


        [Obsolete("Use GetElementByClassName.", true)]
        public T UniqueByClass<T>(string className) where T : HtmlElement
        {
            throw new NotImplementedException();
        }


        [Obsolete("Use GetElementById.", true)]
        public T UniqueById<T>(string id) where T : HtmlElement
        {
            throw new NotImplementedException();
        }


        [Obsolete("Use GetElementByName.", true)]
        public T UniqueByName<T>(string name) where T : HtmlElement
        {
            throw new NotImplementedException();
        }
    }
}