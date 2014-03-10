// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlCaption : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlCaption()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlCaption o) =>
            new HtmlCaption(o));
      }

      public HtmlCaption(com.gargoylesoftware.htmlunit.html.HtmlCaption wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlCaption WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlCaption)WrappedObject; }
      }


      public System.String AlignAttribute
      {
         get
         {
            return WObj.getAlignAttribute();
         }
      }
   }


}
