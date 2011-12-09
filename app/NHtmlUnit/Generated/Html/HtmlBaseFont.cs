// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlBaseFont : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlBaseFont()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlBaseFont o) =>
            new HtmlBaseFont(o));
      }

      public HtmlBaseFont(com.gargoylesoftware.htmlunit.html.HtmlBaseFont wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlBaseFont WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlBaseFont)WrappedObject; }
      }


      public System.String IdAttribute
      {
         get
         {
            return WObj.getIdAttribute();
         }
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
