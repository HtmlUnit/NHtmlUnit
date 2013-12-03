// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlTableHeaderCell : NHtmlUnit.Html.HtmlTableCell, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlTableHeaderCell()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlTableHeaderCell o) =>
            new HtmlTableHeaderCell(o));
      }

      public HtmlTableHeaderCell(com.gargoylesoftware.htmlunit.html.HtmlTableHeaderCell wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlTableHeaderCell WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlTableHeaderCell)WrappedObject; }
      }


      public System.String AbbrAttribute
      {
         get
         {
            return WObj.getAbbrAttribute();
         }
      }

      public System.String AxisAttribute
      {
         get
         {
            return WObj.getAxisAttribute();
         }
      }

      public System.String HeadersAttribute
      {
         get
         {
            return WObj.getHeadersAttribute();
         }
      }

      public System.String ScopeAttribute
      {
         get
         {
            return WObj.getScopeAttribute();
         }
      }

      public System.String RowSpanAttribute
      {
         get
         {
            return WObj.getRowSpanAttribute();
         }
      }

      public System.String ColumnSpanAttribute
      {
         get
         {
            return WObj.getColumnSpanAttribute();
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

      public System.String NoWrapAttribute
      {
         get
         {
            return WObj.getNoWrapAttribute();
         }
      }

      public System.String BgcolorAttribute
      {
         get
         {
            return WObj.getBgcolorAttribute();
         }
      }

      public System.String WidthAttribute
      {
         get
         {
            return WObj.getWidthAttribute();
         }
      }

      public System.String HeightAttribute
      {
         get
         {
            return WObj.getHeightAttribute();
         }
      }
   }


}
