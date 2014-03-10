// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlBreak : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlBreak()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlBreak o) =>
            new HtmlBreak(o));
      }

      public HtmlBreak(com.gargoylesoftware.htmlunit.html.HtmlBreak wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlBreak WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlBreak)WrappedObject; }
      }


      public System.String ClearAttribute
      {
         get
         {
            return WObj.getClearAttribute();
         }
      }
   }


}
