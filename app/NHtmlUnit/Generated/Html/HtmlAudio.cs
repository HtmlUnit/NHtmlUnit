// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlAudio : NHtmlUnit.Html.HtmlMedia, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlAudio()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlAudio o) =>
            new HtmlAudio(o));
      }

      public HtmlAudio(com.gargoylesoftware.htmlunit.html.HtmlAudio wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlAudio WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlAudio)WrappedObject; }
      }

   }


}
