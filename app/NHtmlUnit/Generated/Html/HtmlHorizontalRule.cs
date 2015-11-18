// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlHorizontalRule : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlHorizontalRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlHorizontalRule o) =>
            new HtmlHorizontalRule(o));
      }

      public HtmlHorizontalRule(com.gargoylesoftware.htmlunit.html.HtmlHorizontalRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlHorizontalRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlHorizontalRule)WrappedObject; }
      }


      public System.String AlignAttribute
      {
         get
         {
            return WObj.getAlignAttribute();
         }
      }

      public System.String NoShadeAttribute
      {
         get
         {
            return WObj.getNoShadeAttribute();
         }
      }

      public System.String SizeAttribute
      {
         get
         {
            return WObj.getSizeAttribute();
         }
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
