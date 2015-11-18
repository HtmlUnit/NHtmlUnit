// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlTemplate : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlTemplate()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlTemplate o) =>
            new HtmlTemplate(o));
      }

      public HtmlTemplate(com.gargoylesoftware.htmlunit.html.HtmlTemplate wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlTemplate WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlTemplate)WrappedObject; }
      }

   }


}
