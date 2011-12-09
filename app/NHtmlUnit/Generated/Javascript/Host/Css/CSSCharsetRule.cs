// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSCharsetRule : NHtmlUnit.Javascript.Host.Css.CSSRule
   {
      static CSSCharsetRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSCharsetRule o) =>
            new CSSCharsetRule(o));
      }

      public CSSCharsetRule(com.gargoylesoftware.htmlunit.javascript.host.css.CSSCharsetRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSCharsetRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSCharsetRule)WrappedObject; }
      }

// Generating method code for jsxGet_encoding
      public virtual string JsxGet_encoding()
      {
         return WObj.jsxGet_encoding();
      }

// Generating method code for jsxSet_encoding
      public virtual void JsxSet_encoding(string encoding)
      {
         WObj.jsxSet_encoding(encoding);
      }

   }


}
