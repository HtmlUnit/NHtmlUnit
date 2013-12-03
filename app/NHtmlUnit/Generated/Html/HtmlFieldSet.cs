// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlFieldSet : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlFieldSet()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlFieldSet o) =>
            new HtmlFieldSet(o));
      }

      public HtmlFieldSet(com.gargoylesoftware.htmlunit.html.HtmlFieldSet wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlFieldSet WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlFieldSet)WrappedObject; }
      }

   }


}
