// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSStyleRule : NHtmlUnit.Javascript.Host.Css.CSSRule
   {
      static CSSStyleRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleRule o) =>
            new CSSStyleRule(o));
      }

      public CSSStyleRule(com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleRule)WrappedObject; }
      }

// Generating method code for jsxGet_selectorText
      public virtual string JsxGet_selectorText()
      {
         return WObj.jsxGet_selectorText();
      }

// Generating method code for jsxSet_selectorText
      public virtual void JsxSet_selectorText(string selectorText)
      {
         WObj.jsxSet_selectorText(selectorText);
      }

// Generating method code for jsxGet_style
      public virtual NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration JsxGet_style()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration>(WObj.jsxGet_style());
      }

   }


}
