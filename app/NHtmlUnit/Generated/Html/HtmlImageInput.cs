// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlImageInput : NHtmlUnit.Html.HtmlInput, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.Html.IDisabledElement, NHtmlUnit.Html.ISubmittableElement, NHtmlUnit.Html.IFormFieldWithNameHistory, NHtmlUnit.Html.ILabelableElement
   {
      static HtmlImageInput()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlImageInput o) =>
            new HtmlImageInput(o));
      }

      public HtmlImageInput(com.gargoylesoftware.htmlunit.html.HtmlImageInput wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlImageInput WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlImageInput)WrappedObject; }
      }

// Generating method code for click
      public virtual NHtmlUnit.IPage Click(int x, int y)
      {
         var arg = WObj.click(x, y);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(arg);
      }

// Generating method code for saveAs
      public virtual void SaveAs(java.io.File file)
      {
         WObj.saveAs(file);
      }

   }


}
