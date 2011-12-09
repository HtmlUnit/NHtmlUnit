// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLStyleElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLStyleElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLStyleElement o) =>
            new HTMLStyleElement(o));
      }

      public HTMLStyleElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLStyleElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLStyleElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLStyleElement)WrappedObject; }
      }

      public HTMLStyleElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLStyleElement()) {}

// Generating method code for jsxGet_sheet
      public virtual NHtmlUnit.Javascript.Host.Css.CSSStyleSheet JsxGet_sheet()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleSheet>(WObj.jsxGet_sheet());
      }

// Generating method code for jsxGet_styleSheet
      public virtual NHtmlUnit.Javascript.Host.Css.CSSStyleSheet JsxGet_styleSheet()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleSheet>(WObj.jsxGet_styleSheet());
      }

   }


}
