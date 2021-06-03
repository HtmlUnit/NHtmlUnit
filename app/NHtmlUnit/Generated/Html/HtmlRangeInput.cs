// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlRangeInput : NHtmlUnit.Html.HtmlInput, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.Html.IDisabledElement, NHtmlUnit.Html.ISubmittableElement, NHtmlUnit.Html.IFormFieldWithNameHistory, NHtmlUnit.Html.ILabelableElement
   {
      static HtmlRangeInput()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlRangeInput o) =>
            new HtmlRangeInput(o));
      }

      public HtmlRangeInput(com.gargoylesoftware.htmlunit.html.HtmlRangeInput wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlRangeInput WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlRangeInput)WrappedObject; }
      }


      public System.Double MinNumeric
      {
         get
         {
            return WObj.getMinNumeric();
         }
      }

      public System.Double MaxNumeric
      {
         get
         {
            return WObj.getMaxNumeric();
         }
      }

      public System.Double StepNumeric
      {
         get
         {
            return WObj.getStepNumeric();
         }
      }
   }


}
