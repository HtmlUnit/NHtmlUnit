// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlDeletedText : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlDeletedText()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlDeletedText o) =>
            new HtmlDeletedText(o));
      }

      public HtmlDeletedText(com.gargoylesoftware.htmlunit.html.HtmlDeletedText wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlDeletedText WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlDeletedText)WrappedObject; }
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
