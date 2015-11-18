// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSSupportsRule : NHtmlUnit.Javascript.Host.Css.CSSConditionRule
   {
      static CSSSupportsRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSSupportsRule o) =>
            new CSSSupportsRule(o));
      }

      public CSSSupportsRule(com.gargoylesoftware.htmlunit.javascript.host.css.CSSSupportsRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSSupportsRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSSupportsRule)WrappedObject; }
      }

      public CSSSupportsRule()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSSupportsRule()) {}

   }


}
