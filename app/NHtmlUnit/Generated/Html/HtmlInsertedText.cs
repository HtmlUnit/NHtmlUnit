// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlInsertedText : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlInsertedText()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlInsertedText o) =>
            new HtmlInsertedText(o));
      }

      public HtmlInsertedText(com.gargoylesoftware.htmlunit.html.HtmlInsertedText wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlInsertedText WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlInsertedText)WrappedObject; }
      }


      public System.String CiteAttribute
      {
         get
         {
            return WObj.getCiteAttribute();
         }
      }

      public System.String DateTimeAttribute
      {
         get
         {
            return WObj.getDateTimeAttribute();
         }
      }
   }


}
