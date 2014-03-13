// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlTableColumnGroup : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlTableColumnGroup()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlTableColumnGroup o) =>
            new HtmlTableColumnGroup(o));
      }

      public HtmlTableColumnGroup(com.gargoylesoftware.htmlunit.html.HtmlTableColumnGroup wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlTableColumnGroup WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlTableColumnGroup)WrappedObject; }
      }


      public System.String SpanAttribute
      {
         get
         {
            return WObj.getSpanAttribute();
         }
      }

      public System.String WidthAttribute
      {
         get
         {
            return WObj.getWidthAttribute();
         }
      }

      public System.String AlignAttribute
      {
         get
         {
            return WObj.getAlignAttribute();
         }
      }

      public System.String CharAttribute
      {
         get
         {
            return WObj.getCharAttribute();
         }
      }

      public System.String CharoffAttribute
      {
         get
         {
            return WObj.getCharoffAttribute();
         }
      }

      public System.String ValignAttribute
      {
         get
         {
            return WObj.getValignAttribute();
         }
      }
   }


}
