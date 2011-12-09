// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlHead : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlHead()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlHead o) =>
            new HtmlHead(o));
      }

      public HtmlHead(com.gargoylesoftware.htmlunit.html.HtmlHead wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlHead WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlHead)WrappedObject; }
      }


      public System.String ProfileAttribute
      {
         get
         {
            return WObj.getProfileAttribute();
         }
      }
   }


}
