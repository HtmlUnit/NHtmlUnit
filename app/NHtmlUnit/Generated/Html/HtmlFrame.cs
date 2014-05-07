// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlFrame : NHtmlUnit.Html.BaseFrameElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlFrame()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlFrame o) =>
            new HtmlFrame(o));
      }

      public HtmlFrame(com.gargoylesoftware.htmlunit.html.HtmlFrame wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlFrame WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlFrame)WrappedObject; }
      }

   }


}
