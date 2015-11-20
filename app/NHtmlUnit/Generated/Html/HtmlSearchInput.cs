// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlSearchInput : NHtmlUnit.Html.HtmlTextInput, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal, NHtmlUnit.Html.IDisabledElement, NHtmlUnit.Html.ISubmittableElement, NHtmlUnit.Html.IFormFieldWithNameHistory, NHtmlUnit.Html.Impl.ISelectableTextInput
   {
      static HtmlSearchInput()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlSearchInput o) =>
            new HtmlSearchInput(o));
      }

      public HtmlSearchInput(com.gargoylesoftware.htmlunit.html.HtmlSearchInput wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlSearchInput WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlSearchInput)WrappedObject; }
      }

   }


}
