// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlFileInput : NHtmlUnit.Html.HtmlInput, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal, NHtmlUnit.Html.IDisabledElement, NHtmlUnit.Html.ISubmittableElement, NHtmlUnit.Html.IFormFieldWithNameHistory
   {
      static HtmlFileInput()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlFileInput o) =>
            new HtmlFileInput(o));
      }

      public HtmlFileInput(com.gargoylesoftware.htmlunit.html.HtmlFileInput wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlFileInput WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlFileInput)WrappedObject; }
      }


      public System.Byte[] Data
      {
         get
         {
            return WObj.getData();
         }
         set
         {
            WObj.setData(value);
         }

      }

      public System.String ContentType
      {
         get
         {
            return WObj.getContentType();
         }
         set
         {
            WObj.setContentType(value);
         }

      }
   }


}
