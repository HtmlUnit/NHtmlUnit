// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlSubmitInput : NHtmlUnit.Html.HtmlInput, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.Html.IDisabledElement, NHtmlUnit.Html.ISubmittableElement, NHtmlUnit.Html.IFormFieldWithNameHistory, NHtmlUnit.Html.ILabelableElement
   {
      static HtmlSubmitInput()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlSubmitInput o) =>
            new HtmlSubmitInput(o));
      }

      public HtmlSubmitInput(com.gargoylesoftware.htmlunit.html.HtmlSubmitInput wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlSubmitInput WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlSubmitInput)WrappedObject; }
      }

   }


}
