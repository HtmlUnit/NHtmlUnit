// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSConditionRule : NHtmlUnit.Javascript.Host.Css.CSSGroupingRule
   {
      static CSSConditionRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSConditionRule o) =>
            new CSSConditionRule(o));
      }

      public CSSConditionRule(com.gargoylesoftware.htmlunit.javascript.host.css.CSSConditionRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSConditionRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSConditionRule)WrappedObject; }
      }

      public CSSConditionRule()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSConditionRule()) {}

   }


}
