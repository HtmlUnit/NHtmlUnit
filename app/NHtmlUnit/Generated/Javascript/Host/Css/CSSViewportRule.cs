// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSViewportRule : NHtmlUnit.Javascript.Host.Css.CSSRule
   {
      static CSSViewportRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSViewportRule o) =>
            new CSSViewportRule(o));
      }

      public CSSViewportRule(com.gargoylesoftware.htmlunit.javascript.host.css.CSSViewportRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSViewportRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSViewportRule)WrappedObject; }
      }

      public CSSViewportRule()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSViewportRule()) {}

   }


}
