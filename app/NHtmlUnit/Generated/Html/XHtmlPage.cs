// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class XHtmlPage : NHtmlUnit.Html.HtmlPage, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IDocument, NHtmlUnit.IPage
   {
      static XHtmlPage()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.XHtmlPage o) =>
            new XHtmlPage(o));
      }

      public XHtmlPage(com.gargoylesoftware.htmlunit.html.XHtmlPage wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.XHtmlPage WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.XHtmlPage)WrappedObject; }
      }

      public XHtmlPage(java.net.URL originatingUrl, NHtmlUnit.WebResponse webResponse, NHtmlUnit.IWebWindow webWindow)
         : this(new com.gargoylesoftware.htmlunit.html.XHtmlPage(originatingUrl, (com.gargoylesoftware.htmlunit.WebResponse)webResponse.WrappedObject, (com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject)) {}

   }


}
