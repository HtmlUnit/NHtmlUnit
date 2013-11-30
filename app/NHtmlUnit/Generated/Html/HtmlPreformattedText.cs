// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlPreformattedText : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlPreformattedText()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlPreformattedText o) =>
            new HtmlPreformattedText(o));
      }

      public HtmlPreformattedText(com.gargoylesoftware.htmlunit.html.HtmlPreformattedText wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlPreformattedText WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlPreformattedText)WrappedObject; }
      }


      public System.String WidthAttribute
      {
         get
         {
            return WObj.getWidthAttribute();
         }
      }
   }


}
