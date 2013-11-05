// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlVariable : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlVariable()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlVariable o) =>
            new HtmlVariable(o));
      }

      public HtmlVariable(com.gargoylesoftware.htmlunit.html.HtmlVariable wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlVariable WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlVariable)WrappedObject; }
      }

   }


}
