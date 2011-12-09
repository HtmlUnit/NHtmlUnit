// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSRule : NHtmlUnit.Javascript.SimpleScriptable
   {
      static CSSRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSRule o) =>
            new CSSRule(o));
      }

      public CSSRule(com.gargoylesoftware.htmlunit.javascript.host.css.CSSRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSRule)WrappedObject; }
      }

// Generating method code for jsxGet_type
      public virtual System.Int16 JsxGet_type()
      {
         return WObj.jsxGet_type();
      }

// Generating method code for jsxGet_cssText
      public virtual string JsxGet_cssText()
      {
         return WObj.jsxGet_cssText();
      }

// Generating method code for jsxSet_cssText
      public virtual void JsxSet_cssText(string cssText)
      {
         WObj.jsxSet_cssText(cssText);
      }

// Generating method code for jsxGet_parentStyleSheet
      public virtual NHtmlUnit.Javascript.Host.Css.CSSStyleSheet JsxGet_parentStyleSheet()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleSheet>(WObj.jsxGet_parentStyleSheet());
      }

// Generating method code for jsxGet_parentRule
      public virtual NHtmlUnit.Javascript.Host.Css.CSSRule JsxGet_parentRule()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSRule>(WObj.jsxGet_parentRule());
      }

   }


}
