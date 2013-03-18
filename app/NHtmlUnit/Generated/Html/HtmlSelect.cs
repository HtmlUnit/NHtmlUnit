// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlSelect : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal, NHtmlUnit.Html.IDisabledElement, NHtmlUnit.Html.ISubmittableElement, NHtmlUnit.Html.IFormFieldWithNameHistory
   {
      static HtmlSelect()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlSelect o) =>
            new HtmlSelect(o));
      }

      public HtmlSelect(com.gargoylesoftware.htmlunit.html.HtmlSelect wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlSelect WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlSelect)WrappedObject; }
      }


      public System.Int32 OptionSize
      {
         get
         {
            return WObj.getOptionSize();
         }
         set
         {
            WObj.setOptionSize(value);
         }

      }

      public System.String NameAttribute
      {
         get
         {
            return WObj.getNameAttribute();
         }
      }

      public System.String SizeAttribute
      {
         get
         {
            return WObj.getSizeAttribute();
         }
      }

      public IList<NHtmlUnit.Html.HtmlOption> SelectedOptions
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Html.HtmlOption>(
               WObj.getSelectedOptions());
         }
       }

      public IList<NHtmlUnit.Html.HtmlOption> Options
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Html.HtmlOption>(
               WObj.getOptions());
         }
       }

      public com.gargoylesoftware.htmlunit.util.NameValuePair[] SubmitKeyValuePairs
      {
         get
         {
            return WObj.getSubmitKeyValuePairs();
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

      public System.String MultipleAttribute
      {
         get
         {
            return WObj.getMultipleAttribute();
         }
      }

      public System.String DisabledAttribute
      {
         get
         {
            return WObj.getDisabledAttribute();
         }
      }

      public System.String TabIndexAttribute
      {
         get
         {
            return WObj.getTabIndexAttribute();
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

      public System.String OnChangeAttribute
      {
         get
         {
            return WObj.getOnChangeAttribute();
         }
      }

      public System.String OriginalName
      {
         get
         {
            return WObj.getOriginalName();
         }
      }

      public ICollection<System.String> PreviousNames
      {
         get
         {
            return new ShallowCollectionWrapper<System.String>(
               WObj.getPreviousNames());
         }
       }
// Generating method code for isMultipleSelectEnabled
      public virtual bool IsMultipleSelectEnabled()
      {
         return WObj.isMultipleSelectEnabled();
      }

// Generating method code for setSelectedAttribute
      public virtual NHtmlUnit.IPage SetSelectedAttribute(NHtmlUnit.Html.HtmlOption selectedOption, bool isSelected, bool invokeOnFocus)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.setSelectedAttribute((com.gargoylesoftware.htmlunit.html.HtmlOption)selectedOption.WrappedObject, isSelected, invokeOnFocus));
      }

// Generating method code for setSelectedAttribute
      public virtual NHtmlUnit.IPage SetSelectedAttribute(NHtmlUnit.Html.HtmlOption selectedOption, bool isSelected)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.setSelectedAttribute((com.gargoylesoftware.htmlunit.html.HtmlOption)selectedOption.WrappedObject, isSelected));
      }

// Generating method code for getOptionByValue
      public virtual NHtmlUnit.Html.HtmlOption GetOptionByValue(string value)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlOption>(WObj.getOptionByValue(value));
      }

// Generating method code for setSelectedAttribute
      public virtual NHtmlUnit.IPage SetSelectedAttribute(string optionValue, bool isSelected)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.setSelectedAttribute(optionValue, isSelected));
      }

// Generating method code for getOption
      public virtual NHtmlUnit.Html.HtmlOption GetOption(int index)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlOption>(WObj.getOption(index));
      }

// Generating method code for removeOption
      public virtual void RemoveOption(int index)
      {
         WObj.removeOption(index);
      }

// Generating method code for replaceOption
      public virtual void ReplaceOption(int index, NHtmlUnit.Html.HtmlOption newOption)
      {
         WObj.replaceOption(index, (com.gargoylesoftware.htmlunit.html.HtmlOption)newOption.WrappedObject);
      }

// Generating method code for appendOption
      public virtual void AppendOption(NHtmlUnit.Html.HtmlOption newOption)
      {
         WObj.appendOption((com.gargoylesoftware.htmlunit.html.HtmlOption)newOption.WrappedObject);
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

// Generating method code for getOptionByText
      public virtual NHtmlUnit.Html.HtmlOption GetOptionByText(string text)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlOption>(WObj.getOptionByText(text));
      }

// Generating method code for isDisabled
      public virtual bool IsDisabled()
      {
         return WObj.isDisabled();
      }

   }


}
