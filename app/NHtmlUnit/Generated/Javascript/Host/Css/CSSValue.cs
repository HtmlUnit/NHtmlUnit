// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSValue : NHtmlUnit.Javascript.SimpleScriptable
   {
      static CSSValue()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSValue o) =>
            new CSSValue(o));
      }

      public CSSValue(com.gargoylesoftware.htmlunit.javascript.host.css.CSSValue wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSValue WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSValue)WrappedObject; }
      }

      public CSSValue()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSValue()) {}

// Generating method code for jsxGet_cssText
      public virtual string JsxGet_cssText()
      {
         return WObj.jsxGet_cssText();
      }

   }


}
