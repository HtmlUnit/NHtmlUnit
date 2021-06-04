// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlBlockQuote : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlBlockQuote()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlBlockQuote o) =>
            new HtmlBlockQuote(o));
      }

      public HtmlBlockQuote(com.gargoylesoftware.htmlunit.html.HtmlBlockQuote wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlBlockQuote WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlBlockQuote)WrappedObject; }
      }


      public System.String CiteAttribute
      {
         get
         {
            return WObj.getCiteAttribute();
         }
      }
   }


}
