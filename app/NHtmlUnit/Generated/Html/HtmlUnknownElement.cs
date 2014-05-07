// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlUnknownElement : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlUnknownElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlUnknownElement o) =>
            new HtmlUnknownElement(o));
      }

      public HtmlUnknownElement(com.gargoylesoftware.htmlunit.html.HtmlUnknownElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlUnknownElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlUnknownElement)WrappedObject; }
      }

   }


}
