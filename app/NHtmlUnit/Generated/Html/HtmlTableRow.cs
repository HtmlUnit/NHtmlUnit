// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlTableRow : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlTableRow()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlTableRow o) =>
            new HtmlTableRow(o));
      }

      public HtmlTableRow(com.gargoylesoftware.htmlunit.html.HtmlTableRow wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlTableRow WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlTableRow)WrappedObject; }
      }


      public IList<NHtmlUnit.Html.HtmlTableCell> Cells
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Html.HtmlTableCell>(
               WObj.getCells());
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

      public NHtmlUnit.Html.HtmlTable EnclosingTable
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlTable>(
               WObj.getEnclosingTable());
         }
      }


      public System.String BgcolorAttribute
      {
         get
         {
            return WObj.getBgcolorAttribute();
         }
      }
// Generating method code for getCell
      public virtual NHtmlUnit.Html.HtmlTableCell GetCell(int index)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlTableCell>(WObj.getCell(index));
      }

   }


}
