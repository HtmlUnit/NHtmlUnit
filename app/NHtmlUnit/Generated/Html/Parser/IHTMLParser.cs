// Wrapper for com.gargoylesoftware.htmlunit.html.parser.HTMLParser
// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit.Html.Parser
{
   public interface IHTMLParser : NHtmlUnit.IObjectWrapper
   {
      NHtmlUnit.Html.IElementFactory SvgFactory  { get; }
// Generating method code for parse
      void Parse(NHtmlUnit.WebResponse wr, NHtmlUnit.Html.HtmlPage hp, bool b);
// Generating method code for getFactory
      NHtmlUnit.Html.IElementFactory GetFactory(string str);
// Generating method code for getElementFactory
      NHtmlUnit.Html.IElementFactory GetElementFactory(NHtmlUnit.SgmlPage sp, string str1, string str2, bool b1, bool b2);
// Generating method code for parseFragment
      void ParseFragment(NHtmlUnit.Html.DomNode dn, string str);
// Generating method code for parseFragment
      void ParseFragment(NHtmlUnit.Html.DomNode dn1, NHtmlUnit.Html.DomNode dn2, string str);

   }
}
