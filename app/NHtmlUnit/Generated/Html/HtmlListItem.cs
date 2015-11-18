// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlListItem : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlListItem()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlListItem o) =>
            new HtmlListItem(o));
      }

      public HtmlListItem(com.gargoylesoftware.htmlunit.html.HtmlListItem wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlListItem WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlListItem)WrappedObject; }
      }


      public System.String TypeAttribute
      {
         get
         {
            return WObj.getTypeAttribute();
         }
      }

      public System.String ValueAttribute
      {
         get
         {
            return WObj.getValueAttribute();
         }
      }
   }


}
