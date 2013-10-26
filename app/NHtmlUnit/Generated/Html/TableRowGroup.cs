// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class TableRowGroup : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static TableRowGroup()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.TableRowGroup o) =>
            new TableRowGroup(o));
      }

      public TableRowGroup(com.gargoylesoftware.htmlunit.html.TableRowGroup wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.TableRowGroup WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.TableRowGroup)WrappedObject; }
      }


      public IList<NHtmlUnit.Html.HtmlTableRow> Rows
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Html.HtmlTableRow>(
               WObj.getRows());
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
