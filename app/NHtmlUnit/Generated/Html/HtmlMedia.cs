// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlMedia : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlMedia()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlMedia o) =>
            new HtmlMedia(o));
      }

      public HtmlMedia(com.gargoylesoftware.htmlunit.html.HtmlMedia wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlMedia WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlMedia)WrappedObject; }
      }

// Generating method code for canPlayType
      public virtual string CanPlayType(string type)
      {
         return WObj.canPlayType(type);
      }

   }


}
