// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTextAreaElement : NHtmlUnit.Javascript.Host.FormField, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLTextAreaElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTextAreaElement o) =>
            new HTMLTextAreaElement(o));
      }

      public HTMLTextAreaElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTextAreaElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTextAreaElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTextAreaElement)WrappedObject; }
      }

      public HTMLTextAreaElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTextAreaElement()) {}

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

// Generating method code for jsxGet_cols
      public virtual int JsxGet_cols()
      {
         return WObj.jsxGet_cols();
      }

// Generating method code for jsxSet_cols
      public virtual void JsxSet_cols(string cols)
      {
         WObj.jsxSet_cols(cols);
      }

// Generating method code for jsxGet_rows
      public virtual int JsxGet_rows()
      {
         return WObj.jsxGet_rows();
      }

// Generating method code for jsxSet_rows
      public virtual void JsxSet_rows(string rows)
      {
         WObj.jsxSet_rows(rows);
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

// Generating method code for jsxFunction_setSelectionRange
      public virtual void JsxFunction_setSelectionRange(int start, int end)
      {
         WObj.jsxFunction_setSelectionRange(start, end);
      }

// Generating method code for jsxFunction_select
      public virtual void JsxFunction_select()
      {
         WObj.jsxFunction_select();
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

   }


}
