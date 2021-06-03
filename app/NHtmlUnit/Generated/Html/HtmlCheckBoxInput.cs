// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlCheckBoxInput : NHtmlUnit.Html.HtmlInput, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.Html.IDisabledElement, NHtmlUnit.Html.ISubmittableElement, NHtmlUnit.Html.IFormFieldWithNameHistory, NHtmlUnit.Html.ILabelableElement
   {
      static HtmlCheckBoxInput()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlCheckBoxInput o) =>
            new HtmlCheckBoxInput(o));
      }

      public HtmlCheckBoxInput(com.gargoylesoftware.htmlunit.html.HtmlCheckBoxInput wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlCheckBoxInput WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlCheckBoxInput)WrappedObject; }
      }

   }


}
