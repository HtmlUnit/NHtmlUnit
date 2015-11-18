// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSKeyframeRule : NHtmlUnit.Javascript.Host.Css.CSSRule
   {
      static CSSKeyframeRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSKeyframeRule o) =>
            new CSSKeyframeRule(o));
      }

      public CSSKeyframeRule(com.gargoylesoftware.htmlunit.javascript.host.css.CSSKeyframeRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSKeyframeRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSKeyframeRule)WrappedObject; }
      }

      public CSSKeyframeRule()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSKeyframeRule()) {}

   }


}
