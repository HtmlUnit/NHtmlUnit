// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLScriptElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLScriptElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLScriptElement o) =>
            new HTMLScriptElement(o));
      }

      public HTMLScriptElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLScriptElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLScriptElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLScriptElement)WrappedObject; }
      }

      public HTMLScriptElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLScriptElement()) {}

// Generating method code for jsxGet_src
      public virtual string JsxGet_src()
      {
         return WObj.jsxGet_src();
      }

// Generating method code for jsxSet_src
      public virtual void JsxSet_src(string src)
      {
         WObj.jsxSet_src(src);
      }

// Generating method code for jsxSet_text
      public virtual void JsxSet_text(string text)
      {
         WObj.jsxSet_text(text);
      }

// Generating method code for jsxGet_type
      public virtual string JsxGet_type()
      {
         return WObj.jsxGet_type();
      }

// Generating method code for jsxSet_type
      public virtual void JsxSet_type(string type)
      {
         WObj.jsxSet_type(type);
      }

// Generating method code for jsxGet_onreadystatechange
      public virtual object JsxGet_onreadystatechange()
      {
         return WObj.jsxGet_onreadystatechange();
      }

// Generating method code for jsxSet_onreadystatechange
      public virtual void JsxSet_onreadystatechange(object handler)
      {
         WObj.jsxSet_onreadystatechange(handler);
      }

// Generating method code for jsxGet_onload
      public virtual object JsxGet_onload()
      {
         return WObj.jsxGet_onload();
      }

// Generating method code for jsxSet_onload
      public virtual void JsxSet_onload(object handler)
      {
         WObj.jsxSet_onload(handler);
      }

// Generating method code for jsxGet_readyState
      public virtual string JsxGet_readyState()
      {
         return WObj.jsxGet_readyState();
      }

   }


}
