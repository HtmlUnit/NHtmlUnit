// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlFont : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlFont()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlFont o) =>
            new HtmlFont(o));
      }

      public HtmlFont(com.gargoylesoftware.htmlunit.html.HtmlFont wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlFont WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlFont)WrappedObject; }
      }


      public System.String SizeAttribute
      {
         get
         {
            return WObj.getSizeAttribute();
         }
      }

      public System.String ColorAttribute
      {
         get
         {
            return WObj.getColorAttribute();
         }
      }

      public System.String FaceAttribute
      {
         get
         {
            return WObj.getFaceAttribute();
         }
      }
   }


}
