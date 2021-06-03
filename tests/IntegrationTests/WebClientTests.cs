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
using java.util;
using NHtmlUnit;
using NHtmlUnit.Html;
using NUnit.Framework;
using List = java.util.List;

namespace IntegrationTests
{
    [TestFixture]
    public class WebClientTests
    {
        [Test]
        public void CanSetAlertHandler()
        {
            var webClient = new WebClient(BrowserVersion.FIREFOX);

            List collectedAlerts = new ArrayList();
            var alertHandler = new CollectingAlertHandler(collectedAlerts);
            webClient.AlertHandler = alertHandler;
        }

        [Test]
        public void DoWikipediaSearch()
        {
            // Note that this test works against live wikipedia.org and requires an active Internet connection
            var webClient = new WebClient(BrowserVersion.FIREFOX);

            webClient.Options.JavaScriptEnabled = false;
            webClient.Options.ActiveXNative = true;
            webClient.Options.CssEnabled = true;

            var page = webClient.GetHtmlPage("http://wikipedia.org");

            page.GetElementById<HtmlInput>("searchInput").Type("network");

            var searchButton = page.HtmlElementDescendants
                .OfType<HtmlButton>()
                .First(b => b.TypeAttribute == "submit");

            searchButton.Click();

            var submitButton = page.GetElementByName("go") as HtmlElement;

            var nextPage = submitButton.Click<HtmlPage>();

            // Check whether enumeration works (at least that it doesnt crash)
            foreach (var child in nextPage.Body.HtmlElementDescendants)
                Console.WriteLine(child.TreeDepth + ": Child in enumerator is " + child);

            var i = 0;

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