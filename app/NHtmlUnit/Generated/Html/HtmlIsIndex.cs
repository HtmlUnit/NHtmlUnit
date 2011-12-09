// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlIsIndex : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.Html.ISubmittableElement
   {
      static HtmlIsIndex()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlIsIndex o) =>
            new HtmlIsIndex(o));
      }

      public HtmlIsIndex(com.gargoylesoftware.htmlunit.html.HtmlIsIndex wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlIsIndex WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlIsIndex)WrappedObject; }
      }


      public System.String PromptAttribute
      {
         get
         {
            return WObj.getPromptAttribute();
         }
      }

      public System.String Value
      {
         get
         {
            return WObj.getValue();
         }
         set
         {
            WObj.setValue(value);
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
