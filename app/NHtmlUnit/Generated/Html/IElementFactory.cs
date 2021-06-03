// Wrapper for com.gargoylesoftware.htmlunit.html.ElementFactory
// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit.Html
{
   public interface IElementFactory : NHtmlUnit.IObjectWrapper
   {
// Generating method code for createElement
      NHtmlUnit.Html.DomElement CreateElement(NHtmlUnit.SgmlPage sp, string str, org.xml.sax.Attributes a);
// Generating method code for createElementNS
      NHtmlUnit.Html.DomElement CreateElementNS(NHtmlUnit.SgmlPage sp, string str1, string str2, org.xml.sax.Attributes a);
// Generating method code for createElementNS
      NHtmlUnit.Html.DomElement CreateElementNS(NHtmlUnit.SgmlPage sp, string str1, string str2, org.xml.sax.Attributes a, bool b);

   }
}
