// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlFrameSet : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlFrameSet()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlFrameSet o) =>
            new HtmlFrameSet(o));
      }

      public HtmlFrameSet(com.gargoylesoftware.htmlunit.html.HtmlFrameSet wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlFrameSet WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlFrameSet)WrappedObject; }
      }


      public System.String RowsAttribute
      {
         get
         {
            return WObj.getRowsAttribute();
         }
      }

      public System.String ColsAttribute
      {
         get
         {
            return WObj.getColsAttribute();
         }
      }

      public System.String OnLoadAttribute
      {
         get
         {
            return WObj.getOnLoadAttribute();
         }
      }

      public System.String OnUnloadAttribute
      {
         get
         {
            return WObj.getOnUnloadAttribute();
         }
      }
   }


}
