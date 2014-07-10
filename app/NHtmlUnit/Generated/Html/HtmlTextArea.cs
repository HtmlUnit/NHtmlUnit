// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlTextArea : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal, NHtmlUnit.Html.IDisabledElement, NHtmlUnit.Html.ISubmittableElement, NHtmlUnit.Html.Impl.ISelectableTextInput, NHtmlUnit.Html.IFormFieldWithNameHistory
   {
      static HtmlTextArea()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlTextArea o) =>
            new HtmlTextArea(o));
      }

      public HtmlTextArea(com.gargoylesoftware.htmlunit.html.HtmlTextArea wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlTextArea WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlTextArea)WrappedObject; }
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

      public System.String NameAttribute
      {
         get
         {
            return WObj.getNameAttribute();
         }
      }

      public System.String DefaultValue
      {
         get
         {
            return WObj.getDefaultValue();
         }
         set
         {
            WObj.setDefaultValue(value);
         }

      }

      public com.gargoylesoftware.htmlunit.util.NameValuePair[] SubmitKeyValuePairs
      {
         get
         {
            return WObj.getSubmitKeyValuePairs();
         }
      }

      public System.String RowsAttribute
      {
         get
         {
            return WObj.getRowsAttribute();
         }
      }

      public System.String ColumnsAttribute
      {
         get
         {
            return WObj.getColumnsAttribute();
         }
      }

      public System.String DisabledAttribute
      {
         get
         {
            return WObj.getDisabledAttribute();
         }
      }

      public System.String ReadOnlyAttribute
      {
         get
         {
            return WObj.getReadOnlyAttribute();
         }
      }

      public System.String TabIndexAttribute
      {
         get
         {
            return WObj.getTabIndexAttribute();
         }
      }

      public System.String AccessKeyAttribute
      {
         get
         {
            return WObj.getAccessKeyAttribute();
         }
      }

      public System.String OnFocusAttribute
      {
         get
         {
            return WObj.getOnFocusAttribute();
         }
      }

      public System.String OnBlurAttribute
      {
         get
         {
            return WObj.getOnBlurAttribute();
         }
      }

      public System.String OnSelectAttribute
      {
         get
         {
            return WObj.getOnSelectAttribute();
         }
      }

      public System.String OnChangeAttribute
      {
         get
         {
            return WObj.getOnChangeAttribute();
         }
      }

      public System.String SelectedText
      {
         get
         {
            return WObj.getSelectedText();
         }
      }

      public System.String OriginalName
      {
         get
         {
            return WObj.getOriginalName();
         }
      }

      public ICollection<System.String> NewNames
      {
         get
         {
            return new ShallowCollectionWrapper<System.String>(
               WObj.getNewNames());
         }
       }
// Generating method code for reset
      public virtual void Reset()
      {
         WObj.reset();
      }

// Generating method code for isDefaultChecked
      public virtual bool IsDefaultChecked()
      {
         return WObj.isDefaultChecked();
      }

// Generating method code for isDisabled
      public virtual bool IsDisabled()
      {
         return WObj.isDisabled();
      }

// Generating method code for select
      public virtual void Select()
      {
         WObj.select();
      }

// Generating method code for isReadOnly
      public virtual bool IsReadOnly()
      {
         return WObj.isReadOnly();
      }

   }


}
