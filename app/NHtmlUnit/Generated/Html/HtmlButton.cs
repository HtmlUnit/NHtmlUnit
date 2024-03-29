// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlButton : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.Html.IDisabledElement, NHtmlUnit.Html.ISubmittableElement, NHtmlUnit.Html.ILabelableElement, NHtmlUnit.Html.IFormFieldWithNameHistory
   {
      static HtmlButton()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlButton o) =>
            new HtmlButton(o));
      }

      public HtmlButton(com.gargoylesoftware.htmlunit.html.HtmlButton wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlButton WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlButton)WrappedObject; }
      }


      public System.String NameAttribute
      {
         get
         {
            return WObj.getNameAttribute();
         }
      }

      public System.String Type
      {
         get
         {
            return WObj.getType();
         }
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

      public System.String TypeAttribute
      {
         get
         {
            return WObj.getTypeAttribute();
         }
      }

      public com.gargoylesoftware.htmlunit.util.NameValuePair[] SubmitNameValuePairs
      {
         get
         {
            return WObj.getSubmitNameValuePairs();
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

   }


}
