// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class TextRange : NHtmlUnit.Javascript.SimpleScriptable
   {
      static TextRange()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.TextRange o) =>
            new TextRange(o));
      }

      public TextRange(com.gargoylesoftware.htmlunit.javascript.host.TextRange wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.TextRange WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.TextRange)WrappedObject; }
      }

      public TextRange(NHtmlUnit.Javascript.Host.Html.HTMLElement elt)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.TextRange((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)elt.WrappedObject)) {}

      public TextRange(NHtmlUnit.W3C.Dom.Ranges.IRange range)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.TextRange((org.w3c.dom.ranges.Range)range.WrappedObject)) {}

      public TextRange()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.TextRange()) {}

// Generating method code for jsxGet_text
      public virtual string JsxGet_text()
      {
         return WObj.jsxGet_text();
      }

// Generating method code for jsxSet_text
      public virtual void JsxSet_text(string text)
      {
         WObj.jsxSet_text(text);
      }

// Generating method code for jsxGet_htmlText
      public virtual string JsxGet_htmlText()
      {
         return WObj.jsxGet_htmlText();
      }

// Generating method code for jsxFunction_duplicate
      public virtual object JsxFunction_duplicate()
      {
         return WObj.jsxFunction_duplicate();
      }

// Generating method code for jsxFunction_parentElement
      public virtual object JsxFunction_parentElement()
      {
         return WObj.jsxFunction_parentElement();
      }

// Generating method code for jsxFunction_collapse
      public virtual void JsxFunction_collapse(bool toStart)
      {
         WObj.jsxFunction_collapse(toStart);
      }

// Generating method code for jsxFunction_select
      public virtual void JsxFunction_select()
      {
         WObj.jsxFunction_select();
      }

// Generating method code for jsxFunction_moveStart
      public virtual int JsxFunction_moveStart(string unit, object count)
      {
         return WObj.jsxFunction_moveStart(unit, count);
      }

// Generating method code for jsxFunction_moveEnd
      public virtual int JsxFunction_moveEnd(string unit, object count)
      {
         return WObj.jsxFunction_moveEnd(unit, count);
      }

// Generating method code for jsxFunction_moveToElementText
      public virtual void JsxFunction_moveToElementText(NHtmlUnit.Javascript.Host.Html.HTMLElement element)
      {
         WObj.jsxFunction_moveToElementText((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)element.WrappedObject);
      }

// Generating method code for jsxFunction_inRange
      public virtual bool JsxFunction_inRange(NHtmlUnit.Javascript.Host.TextRange other)
      {
         return WObj.jsxFunction_inRange((com.gargoylesoftware.htmlunit.javascript.host.TextRange)other.WrappedObject);
      }

// Generating method code for jsxFunction_setEndPoint
      public virtual void JsxFunction_setEndPoint(string type, NHtmlUnit.Javascript.Host.TextRange other)
      {
         WObj.jsxFunction_setEndPoint(type, (com.gargoylesoftware.htmlunit.javascript.host.TextRange)other.WrappedObject);
      }

   }


}
