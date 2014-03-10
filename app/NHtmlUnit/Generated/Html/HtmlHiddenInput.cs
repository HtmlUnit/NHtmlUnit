// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlHiddenInput : NHtmlUnit.Html.HtmlInput, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal, NHtmlUnit.Html.IDisabledElement, NHtmlUnit.Html.ISubmittableElement, NHtmlUnit.Html.IFormFieldWithNameHistory
   {
      static HtmlHiddenInput()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlHiddenInput o) =>
            new HtmlHiddenInput(o));
      }

      public HtmlHiddenInput(com.gargoylesoftware.htmlunit.html.HtmlHiddenInput wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlHiddenInput WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlHiddenInput)WrappedObject; }
      }

   }


}
