// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlUrlInput : NHtmlUnit.Html.HtmlInput, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.Html.IDisabledElement, NHtmlUnit.Html.ISubmittableElement, NHtmlUnit.Html.IFormFieldWithNameHistory, NHtmlUnit.Html.Impl.ISelectableTextInput, NHtmlUnit.Html.ILabelableElement
   {
      static HtmlUrlInput()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlUrlInput o) =>
            new HtmlUrlInput(o));
      }

      public HtmlUrlInput(com.gargoylesoftware.htmlunit.html.HtmlUrlInput wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlUrlInput WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlUrlInput)WrappedObject; }
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
