// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlRt : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlRt()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlRt o) =>
            new HtmlRt(o));
      }

      public HtmlRt(com.gargoylesoftware.htmlunit.html.HtmlRt wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlRt WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlRt)WrappedObject; }
      }

// Generating method code for wasCreatedByJavascript
      public virtual bool WasCreatedByJavascript()
      {
         return WObj.wasCreatedByJavascript();
      }

// Generating method code for markAsCreatedByJavascript
      public virtual void MarkAsCreatedByJavascript()
      {
         WObj.markAsCreatedByJavascript();
      }

   }


}
