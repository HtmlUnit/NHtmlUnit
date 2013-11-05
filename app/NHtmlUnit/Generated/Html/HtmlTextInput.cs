// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlTextInput : NHtmlUnit.Html.HtmlInput, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal, NHtmlUnit.Html.IDisabledElement, NHtmlUnit.Html.ISubmittableElement, NHtmlUnit.Html.IFormFieldWithNameHistory, NHtmlUnit.Html.Impl.ISelectableTextInput
   {
      static HtmlTextInput()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlTextInput o) =>
            new HtmlTextInput(o));
      }

      public HtmlTextInput(com.gargoylesoftware.htmlunit.html.HtmlTextInput wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlTextInput WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlTextInput)WrappedObject; }
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
