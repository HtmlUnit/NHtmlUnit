// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSRuleList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static CSSRuleList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSRuleList o) =>
            new CSSRuleList(o));
      }

      public CSSRuleList(com.gargoylesoftware.htmlunit.javascript.host.css.CSSRuleList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSRuleList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSRuleList)WrappedObject; }
      }

      public CSSRuleList(NHtmlUnit.Javascript.Host.Css.CSSStyleSheet stylesheet)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSRuleList((com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleSheet)stylesheet.WrappedObject)) {}

// Generating method code for jsxGet_length
      public virtual int JsxGet_length()
      {
         return WObj.jsxGet_length();
      }

// Generating method code for jsxFunction_item
      public virtual object JsxFunction_item(int index)
      {
         return WObj.jsxFunction_item(index);
      }

   }


}
