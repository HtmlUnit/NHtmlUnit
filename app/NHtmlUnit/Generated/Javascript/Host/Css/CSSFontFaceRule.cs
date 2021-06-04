// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSFontFaceRule : NHtmlUnit.Javascript.Host.Css.CSSRule
   {
      static CSSFontFaceRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSFontFaceRule o) =>
            new CSSFontFaceRule(o));
      }

      public CSSFontFaceRule(com.gargoylesoftware.htmlunit.javascript.host.css.CSSFontFaceRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSFontFaceRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSFontFaceRule)WrappedObject; }
      }

      public CSSFontFaceRule()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSFontFaceRule()) {}

   }


}
