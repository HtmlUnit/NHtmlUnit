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

using NHtmlUnit;
using NHtmlUnit.Html;

using NUnit.Framework;

namespace IntegrationTests
{
    [TestFixture]
    public class WebClientTests
    {
        [Test]
        public void DoWikipediaSearch()
        {
            // Note that this test works against live wikipedia.org and requires an active Internet connection
            WebClient webClient = new WebClient(BrowserVersion.FIREFOX_3_6)
            {
                JavaScriptEnabled = true,
                ActiveXNative = true,
                CssEnabled = true,
            };

            HtmlPage page = webClient.GetHtmlPage("http://wikipedia.org");

            HtmlInput queryInputElement = page.GetElementById<HtmlInput>("searchInput");
            queryInputElement.Type("network");

            HtmlSubmitInput submitButton2 =
                page.HtmlElementDescendants
                    .OfType<HtmlSubmitInput>()
                    .First(e => e.NameAttribute == "go");

            submitButton2.Click();

            HtmlElement submitButton = page.GetElementByName("go");

            HtmlPage nextPage = submitButton.Click<HtmlPage>();

            // Check whether enumeration works (at least that it doesnt crash)
            foreach (var child in nextPage.Body.HtmlElementDescendants)
                Console.WriteLine(child.TreeDepth + ": Child in enumerator is " + child);

            int i = 0;

            // Check whether list wrapper works
            foreach (var child in nextPage.Forms)
            {
                Console.WriteLine(child);
                Assert.AreEqual(child, nextPage.Forms[i]);
                i++;
            }
        }
    }
}