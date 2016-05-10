// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlForm : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlForm()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlForm o) =>
            new HtmlForm(o));
      }

      public HtmlForm(com.gargoylesoftware.htmlunit.html.HtmlForm wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlForm WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlForm)WrappedObject; }
      }


      public System.String ActionAttribute
      {
         get
         {
            return WObj.getActionAttribute();
         }
         set
         {
            WObj.setActionAttribute(value);
         }

      }

      public System.String TargetAttribute
      {
         get
         {
            return WObj.getTargetAttribute();
         }
         set
         {
            WObj.setTargetAttribute(value);
         }

      }

      public System.String MethodAttribute
      {
         get
         {
            return WObj.getMethodAttribute();
         }
         set
         {
            WObj.setMethodAttribute(value);
         }

      }

      public System.String EnctypeAttribute
      {
         get
         {
            return WObj.getEnctypeAttribute();
         }
         set
         {
            WObj.setEnctypeAttribute(value);
         }

      }

      public System.String AcceptCharsetAttribute
      {
         get
         {
            return WObj.getAcceptCharsetAttribute();
         }
      }

      public IList<NHtmlUnit.Html.HtmlElement> LostChildren
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Html.HtmlElement>(
               WObj.getLostChildren());
         }
       }

      public System.String NameAttribute
      {
         get
         {
            return WObj.getNameAttribute();
         }
         set
         {
            WObj.setNameAttribute(value);
         }

      }

      public System.String OnSubmitAttribute
      {
         get
         {
            return WObj.getOnSubmitAttribute();
         }
      }

      public System.String OnResetAttribute
      {
         get
         {
            return WObj.getOnResetAttribute();
         }
      }

      public System.String AcceptAttribute
      {
         get
         {
            return WObj.getAcceptAttribute();
         }
      }
// Generating method code for reset
      public virtual NHtmlUnit.IPage Reset()
      {
         var arg = WObj.reset();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(arg);
      }

// Generating method code for getWebRequest
      public virtual NHtmlUnit.WebRequest GetWebRequest(NHtmlUnit.Html.ISubmittableElement submitElement)
      {
         var arg = WObj.getWebRequest((com.gargoylesoftware.htmlunit.html.SubmittableElement)submitElement.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.WebRequest>(arg);
      }

// Generating method code for getInputsByName
      public virtual IList<NHtmlUnit.Html.HtmlInput> GetInputsByName(string name)
      {

         return new ListWrapper<NHtmlUnit.Html.HtmlInput>(WObj.getInputsByName(name));
      }

// Generating method code for getSelectsByName
      public virtual IList<NHtmlUnit.Html.HtmlSelect> GetSelectsByName(string name)
      {

         return new ListWrapper<NHtmlUnit.Html.HtmlSelect>(WObj.getSelectsByName(name));
      }

// Generating method code for getButtonsByName
      public virtual IList<NHtmlUnit.Html.HtmlButton> GetButtonsByName(string name)
      {

         return new ListWrapper<NHtmlUnit.Html.HtmlButton>(WObj.getButtonsByName(name));
      }

// Generating method code for getTextAreasByName
      public virtual IList<NHtmlUnit.Html.HtmlTextArea> GetTextAreasByName(string name)
      {

         return new ListWrapper<NHtmlUnit.Html.HtmlTextArea>(WObj.getTextAreasByName(name));
      }

// Generating method code for getRadioButtonsByName
      public virtual IList<NHtmlUnit.Html.HtmlRadioButtonInput> GetRadioButtonsByName(string name)
      {

         return new ListWrapper<NHtmlUnit.Html.HtmlRadioButtonInput>(WObj.getRadioButtonsByName(name));
      }

// Generating method code for getInputsByValue
      public virtual IList<NHtmlUnit.Html.HtmlInput> GetInputsByValue(string value)
      {

         return new ListWrapper<NHtmlUnit.Html.HtmlInput>(WObj.getInputsByValue(value));
      }

// Generating method code for getInputByName
      public virtual NHtmlUnit.Html.HtmlInput GetInputByName(string name)
      {
         var arg = WObj.getInputByName(name);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlInput>(arg);
      }

// Generating method code for getSelectByName
      public virtual NHtmlUnit.Html.HtmlSelect GetSelectByName(string name)
      {
         var arg = WObj.getSelectByName(name);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlSelect>(arg);
      }

// Generating method code for getButtonByName
      public virtual NHtmlUnit.Html.HtmlButton GetButtonByName(string name)
      {
         var arg = WObj.getButtonByName(name);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlButton>(arg);
      }

// Generating method code for getTextAreaByName
      public virtual NHtmlUnit.Html.HtmlTextArea GetTextAreaByName(string name)
      {
         var arg = WObj.getTextAreaByName(name);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlTextArea>(arg);
      }

// Generating method code for getCheckedRadioButton
      public virtual NHtmlUnit.Html.HtmlRadioButtonInput GetCheckedRadioButton(string name)
      {
         var arg = WObj.getCheckedRadioButton(name);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlRadioButtonInput>(arg);
      }

// Generating method code for getInputByValue
      public virtual NHtmlUnit.Html.HtmlInput GetInputByValue(string value)
      {
         var arg = WObj.getInputByValue(value);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlInput>(arg);
      }

   }


}
