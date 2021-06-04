// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlTableCell : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlTableCell()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlTableCell o) =>
            new HtmlTableCell(o));
      }

      public HtmlTableCell(com.gargoylesoftware.htmlunit.html.HtmlTableCell wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlTableCell WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlTableCell)WrappedObject; }
      }


      public System.Int32 RowSpan
      {
         get
         {
            return WObj.getRowSpan();
         }
      }

      public System.Int32 ColumnSpan
      {
         get
         {
            return WObj.getColumnSpan();
         }
      }

      public NHtmlUnit.Html.HtmlTableRow EnclosingRow
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlTableRow>(
               WObj.getEnclosingRow());
         }
      }

   }


}
