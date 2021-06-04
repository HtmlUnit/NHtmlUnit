// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlEmailInput : NHtmlUnit.Html.HtmlInput, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.Html.IDisabledElement, NHtmlUnit.Html.ISubmittableElement, NHtmlUnit.Html.IFormFieldWithNameHistory, NHtmlUnit.Html.Impl.ISelectableTextInput, NHtmlUnit.Html.ILabelableElement
   {
      static HtmlEmailInput()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlEmailInput o) =>
            new HtmlEmailInput(o));
      }

      public HtmlEmailInput(com.gargoylesoftware.htmlunit.html.HtmlEmailInput wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlEmailInput WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlEmailInput)WrappedObject; }
      }


      public System.Int32 SelectionEnd
      {
         get
         {
            return WObj.getSelectionEnd();
         }
         set
         {
            WObj.setSelectionEnd(value);
         }

      }

      public System.Int32 SelectionStart
      {
         get
         {
            return WObj.getSelectionStart();
         }
         set
         {
            WObj.setSelectionStart(value);
         }

      }

      public System.String SelectedText
      {
         get
         {
            return WObj.getSelectedText();
         }
      }

      public System.String Text
      {
         get
         {
            return WObj.getText();
         }
         set
         {
            WObj.setText(value);
         }

      }
// Generating method code for select
      public virtual void Select()
      {
         WObj.select();
      }

   }


}
