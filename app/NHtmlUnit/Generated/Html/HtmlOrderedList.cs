// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlOrderedList : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlOrderedList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlOrderedList o) =>
            new HtmlOrderedList(o));
      }

      public HtmlOrderedList(com.gargoylesoftware.htmlunit.html.HtmlOrderedList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlOrderedList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlOrderedList)WrappedObject; }
      }


      public System.String TypeAttribute
      {
         get
         {
            return WObj.getTypeAttribute();
         }
      }

      public System.String CompactAttribute
      {
         get
         {
            return WObj.getCompactAttribute();
         }
      }

      public System.String StartAttribute
      {
         get
         {
            return WObj.getStartAttribute();
         }
      }
   }


}
