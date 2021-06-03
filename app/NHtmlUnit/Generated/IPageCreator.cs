// Wrapper for com.gargoylesoftware.htmlunit.PageCreator
// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit
{
   public interface IPageCreator : NHtmlUnit.IObjectWrapper
   {
      NHtmlUnit.Html.Parser.IHTMLParser HtmlParser  { get; }
// Generating method code for createPage
      NHtmlUnit.IPage CreatePage(NHtmlUnit.WebResponse wr, NHtmlUnit.IWebWindow ww);

   }
}
