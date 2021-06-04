// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlInlineQuotation : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlInlineQuotation()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlInlineQuotation o) =>
            new HtmlInlineQuotation(o));
      }

      public HtmlInlineQuotation(com.gargoylesoftware.htmlunit.html.HtmlInlineQuotation wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlInlineQuotation WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlInlineQuotation)WrappedObject; }
      }


      public System.String CiteAttribute
      {
         get
         {
            return WObj.getCiteAttribute();
         }
      }
   }


}
