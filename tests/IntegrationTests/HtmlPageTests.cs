using NHtmlUnit;
using NHtmlUnit.Html;
using NUnit.Framework;

namespace IntegrationTests
{
    [TestFixture]
    public class HtmlPageTests
    {
        [Test]
        public void GetFirstByXPath_ReturnsWrappedObject()
        {
            var webClient = new WebClient(BrowserVersion.FIREFOX);

            webClient.Options.JavaScriptEnabled = false;
            webClient.Options.ActiveXNative = false;
            webClient.Options.CssEnabled = false;

            var page = webClient.GetHtmlPage("https://github.com/");
            var anchor = page.GetFirstByXPath("//a");

            Assert.That(anchor, Is.TypeOf<HtmlAnchor>());
        }
    }
}