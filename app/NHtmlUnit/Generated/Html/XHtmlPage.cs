// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class XHtmlPage : NHtmlUnit.Html.HtmlPage, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.IPage, NHtmlUnit.W3C.Dom.IDocument, NHtmlUnit.W3C.Dom.Traversal.IDocumentTraversal
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

      public XHtmlPage(NHtmlUnit.WebResponse webResponse, NHtmlUnit.IWebWindow webWindow)
         : this(new com.gargoylesoftware.htmlunit.html.XHtmlPage((com.gargoylesoftware.htmlunit.WebResponse)webResponse.WrappedObject, (com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject)) {}

   }


}
