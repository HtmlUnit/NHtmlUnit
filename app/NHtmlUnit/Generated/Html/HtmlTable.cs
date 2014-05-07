// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlTable : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlTable()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlTable o) =>
            new HtmlTable(o));
      }

      public HtmlTable(com.gargoylesoftware.htmlunit.html.HtmlTable wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlTable WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlTable)WrappedObject; }
      }


      public System.String CaptionText
      {
         get
         {
            return WObj.getCaptionText();
         }
      }

      public NHtmlUnit.Html.HtmlTableHeader Header
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlTableHeader>(
               WObj.getHeader());
         }
      }


      public NHtmlUnit.Html.HtmlTableFooter Footer
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlTableFooter>(
               WObj.getFooter());
         }
      }


      public IList<NHtmlUnit.Html.HtmlTableRow> Rows
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Html.HtmlTableRow>(
               WObj.getRows());
         }
       }

      public System.Int32 RowCount
      {
         get
         {
            return WObj.getRowCount();
         }
      }

      public IList<NHtmlUnit.Html.HtmlTableBody> Bodies
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Html.HtmlTableBody>(
               WObj.getBodies());
         }
       }

      public System.String SummaryAttribute
      {
         get
         {
            return WObj.getSummaryAttribute();
         }
      }

      public System.String WidthAttribute
      {
         get
         {
            return WObj.getWidthAttribute();
         }
      }

      public System.String BorderAttribute
      {
         get
         {
            return WObj.getBorderAttribute();
         }
      }

      public System.String FrameAttribute
      {
         get
         {
            return WObj.getFrameAttribute();
         }
      }

      public System.String RulesAttribute
      {
         get
         {
            return WObj.getRulesAttribute();
         }
      }

      public System.String CellSpacingAttribute
      {
         get
         {
            return WObj.getCellSpacingAttribute();
         }
      }

      public System.String CellPaddingAttribute
      {
         get
         {
            return WObj.getCellPaddingAttribute();
         }
      }

      public System.String AlignAttribute
      {
         get
         {
            return WObj.getAlignAttribute();
         }
      }

      public System.String BgcolorAttribute
      {
         get
         {
            return WObj.getBgcolorAttribute();
         }
      }
// Generating method code for getCellAt
      public virtual NHtmlUnit.Html.HtmlTableCell GetCellAt(int rowIndex, int columnIndex)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlTableCell>(WObj.getCellAt(rowIndex, columnIndex));
      }

// Generating method code for getRow
      public virtual NHtmlUnit.Html.HtmlTableRow GetRow(int index)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlTableRow>(WObj.getRow(index));
      }

// Generating method code for getRowById
      public virtual NHtmlUnit.Html.HtmlTableRow GetRowById(string id)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlTableRow>(WObj.getRowById(id));
      }

   }


}
