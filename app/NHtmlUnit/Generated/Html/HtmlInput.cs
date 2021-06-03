// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlInput : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.Html.IDisabledElement, NHtmlUnit.Html.ISubmittableElement, NHtmlUnit.Html.IFormFieldWithNameHistory
   {
      static HtmlInput()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlInput o) =>
            new HtmlInput(o));
      }

      public HtmlInput(com.gargoylesoftware.htmlunit.html.HtmlInput wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlInput WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlInput)WrappedObject; }
      }


      public System.String ValueAttribute
      {
         get
         {
            return WObj.getValueAttribute();
         }
         set
         {
            WObj.setValueAttribute(value);
         }

      }

      public System.String NameAttribute
      {
         get
         {
            return WObj.getNameAttribute();
         }
      }

      public System.String MaxLengthAttribute
      {
         get
         {
            return WObj.getMaxLengthAttribute();
         }
      }

      public System.String MinLengthAttribute
      {
         get
         {
            return WObj.getMinLengthAttribute();
         }
      }

      public System.String Pattern
      {
         get
         {
            return WObj.getPattern();
         }
         set
         {
            WObj.setPattern(value);
         }

      }

      public com.gargoylesoftware.htmlunit.util.NameValuePair[] SubmitNameValuePairs
      {
         get
         {
            return WObj.getSubmitNameValuePairs();
         }
      }

      public System.String TypeAttribute
      {
         get
         {
            return WObj.getTypeAttribute();
         }
      }

      public System.String CheckedAttribute
      {
         get
         {
            return WObj.getCheckedAttribute();
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

      public System.String SizeAttribute
      {
         get
         {
            return WObj.getSizeAttribute();
         }
      }

      public System.String SrcAttribute
      {
         get
         {
            return WObj.getSrcAttribute();
         }
         set
         {
            WObj.setSrcAttribute(value);
         }

      }

      public System.String AltAttribute
      {
         get
         {
            return WObj.getAltAttribute();
         }
      }

      public System.String UseMapAttribute
      {
         get
         {
            return WObj.getUseMapAttribute();
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

      public System.String AcceptAttribute
      {
         get
         {
            return WObj.getAcceptAttribute();
         }
      }

      public System.String AlignAttribute
      {
         get
         {
            return WObj.getAlignAttribute();
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

      public System.String Size
      {
         get
         {
            return WObj.getSize();
         }
         set
         {
            WObj.setSize(value);
         }

      }

      public System.String Accept
      {
         get
         {
            return WObj.getAccept();
         }
         set
         {
            WObj.setAccept(value);
         }

      }

      public System.String Autocomplete
      {
         get
         {
            return WObj.getAutocomplete();
         }
         set
         {
            WObj.setAutocomplete(value);
         }

      }

      public System.String Placeholder
      {
         get
         {
            return WObj.getPlaceholder();
         }
         set
         {
            WObj.setPlaceholder(value);
         }

      }

      public System.String Min
      {
         get
         {
            return WObj.getMin();
         }
         set
         {
            WObj.setMin(value);
         }

      }

      public System.String Max
      {
         get
         {
            return WObj.getMax();
         }
         set
         {
            WObj.setMax(value);
         }

      }

      public System.String Step
      {
         get
         {
            return WObj.getStep();
         }
         set
         {
            WObj.setStep(value);
         }

      }
// Generating method code for isDisabled
      public virtual bool IsDisabled()
      {
         return WObj.isDisabled();
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

// Generating method code for setChecked
      public virtual NHtmlUnit.IPage SetChecked(bool isChecked)
      {
         var arg = WObj.setChecked(isChecked);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(arg);
      }

// Generating method code for isChecked
      public virtual bool IsChecked()
      {
         return WObj.isChecked();
      }

// Generating method code for isReadOnly
      public virtual bool IsReadOnly()
      {
         return WObj.isReadOnly();
      }

// Generating method code for markAsCreatedByJavascript
      public virtual void MarkAsCreatedByJavascript()
      {
         WObj.markAsCreatedByJavascript();
      }

// Generating method code for wasCreatedByJavascript
      public virtual bool WasCreatedByJavascript()
      {
         return WObj.wasCreatedByJavascript();
      }

// Generating method code for valueModifiedByJavascript
      public virtual void ValueModifiedByJavascript()
      {
         WObj.valueModifiedByJavascript();
      }

   }


}
