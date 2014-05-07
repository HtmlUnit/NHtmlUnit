// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlHeader : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlHeader()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlHeader o) =>
            new HtmlHeader(o));
      }

      public HtmlHeader(com.gargoylesoftware.htmlunit.html.HtmlHeader wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlHeader WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlHeader)WrappedObject; }
      }

   }


}
