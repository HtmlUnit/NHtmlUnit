// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlStyle : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlStyle()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlStyle o) =>
            new HtmlStyle(o));
      }

      public HtmlStyle(com.gargoylesoftware.htmlunit.html.HtmlStyle wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlStyle WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlStyle)WrappedObject; }
      }


      public System.String TypeAttribute
      {
         get
         {
            return WObj.getTypeAttribute();
         }
      }

      public System.String MediaAttribute
      {
         get
         {
            return WObj.getMediaAttribute();
         }
      }

      public System.String TitleAttribute
      {
         get
         {
            return WObj.getTitleAttribute();
         }
      }
   }


}
