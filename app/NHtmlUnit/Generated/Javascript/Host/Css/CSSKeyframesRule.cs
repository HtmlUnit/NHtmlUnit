// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSKeyframesRule : NHtmlUnit.Javascript.Host.Css.CSSRule
   {
      static CSSKeyframesRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSKeyframesRule o) =>
            new CSSKeyframesRule(o));
      }

      public CSSKeyframesRule(com.gargoylesoftware.htmlunit.javascript.host.css.CSSKeyframesRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSKeyframesRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSKeyframesRule)WrappedObject; }
      }

      public CSSKeyframesRule()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSKeyframesRule()) {}

   }


}
