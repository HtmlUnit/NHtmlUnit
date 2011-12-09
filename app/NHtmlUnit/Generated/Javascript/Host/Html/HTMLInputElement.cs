// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLInputElement : NHtmlUnit.Javascript.Host.FormField, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLInputElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInputElement o) =>
            new HTMLInputElement(o));
      }

      public HTMLInputElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInputElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInputElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInputElement)WrappedObject; }
      }

      public HTMLInputElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInputElement()) {}

// Generating method code for jsxSet_type
      public virtual void JsxSet_type(string newType)
      {
         WObj.jsxSet_type(newType);
      }

// Generating method code for jsxSet_selectionStart
      public virtual void JsxSet_selectionStart(int start)
      {
         WObj.jsxSet_selectionStart(start);
      }

// Generating method code for jsxSet_selectionEnd
      public virtual void JsxSet_selectionEnd(int end)
      {
         WObj.jsxSet_selectionEnd(end);
      }

// Generating method code for jsConstructor
      public virtual void JsConstructor()
      {
         WObj.jsConstructor();
      }

// Generating method code for jsxSet_checked
      public virtual void JsxSet_checked(bool checkedArg)
      {
         WObj.jsxSet_checked(checkedArg);
      }

// Generating method code for jsxGet_checked
      public virtual bool JsxGet_checked()
      {
         return WObj.jsxGet_checked();
      }

// Generating method code for jsxFunction_select
      public virtual void JsxFunction_select()
      {
         WObj.jsxFunction_select();
      }

// Generating method code for jsxGet_defaultValue
      public virtual string JsxGet_defaultValue()
      {
         return WObj.jsxGet_defaultValue();
      }

// Generating method code for jsxSet_defaultValue
      public virtual void JsxSet_defaultValue(string defaultValue)
      {
         WObj.jsxSet_defaultValue(defaultValue);
      }

// Generating method code for jsxGet_defaultChecked
      public virtual bool JsxGet_defaultChecked()
      {
         return WObj.jsxGet_defaultChecked();
      }

// Generating method code for jsxSet_defaultChecked
      public virtual void JsxSet_defaultChecked(bool defaultChecked)
      {
         WObj.jsxSet_defaultChecked(defaultChecked);
      }

// Generating method code for jsxGet_textLength
      public virtual int JsxGet_textLength()
      {
         return WObj.jsxGet_textLength();
      }

// Generating method code for jsxGet_selectionStart
      public virtual int JsxGet_selectionStart()
      {
         return WObj.jsxGet_selectionStart();
      }

// Generating method code for jsxGet_selectionEnd
      public virtual int JsxGet_selectionEnd()
      {
         return WObj.jsxGet_selectionEnd();
      }

// Generating method code for jsxGet_maxLength
      public virtual int JsxGet_maxLength()
      {
         return WObj.jsxGet_maxLength();
      }

// Generating method code for jsxSet_maxLength
      public virtual void JsxSet_maxLength(int length)
      {
         WObj.jsxSet_maxLength(length);
      }

// Generating method code for jsxGet_readOnly
      public virtual bool JsxGet_readOnly()
      {
         return WObj.jsxGet_readOnly();
      }

// Generating method code for jsxSet_readOnly
      public virtual void JsxSet_readOnly(bool readOnly)
      {
         WObj.jsxSet_readOnly(readOnly);
      }

// Generating method code for jsxFunction_setSelectionRange
      public virtual void JsxFunction_setSelectionRange(int start, int end)
      {
         WObj.jsxFunction_setSelectionRange(start, end);
      }

// Generating method code for jsxGet_alt
      public virtual string JsxGet_alt()
      {
         return WObj.jsxGet_alt();
      }

// Generating method code for jsxSet_alt
      public virtual void JsxSet_alt(string alt)
      {
         WObj.jsxSet_alt(alt);
      }

// Generating method code for jsxGet_border
      public virtual string JsxGet_border()
      {
         return WObj.jsxGet_border();
      }

// Generating method code for jsxSet_border
      public virtual void JsxSet_border(string border)
      {
         WObj.jsxSet_border(border);
      }

// Generating method code for jsxGet_align
      public virtual string JsxGet_align()
      {
         return WObj.jsxGet_align();
      }

// Generating method code for jsxSet_align
      public virtual void JsxSet_align(string align)
      {
         WObj.jsxSet_align(align);
      }

   }


}
