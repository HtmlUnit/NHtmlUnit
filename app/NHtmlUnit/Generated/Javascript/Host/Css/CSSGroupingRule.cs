// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSGroupingRule : NHtmlUnit.Javascript.Host.Css.CSSRule
   {
      static CSSGroupingRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSGroupingRule o) =>
            new CSSGroupingRule(o));
      }

      public CSSGroupingRule(com.gargoylesoftware.htmlunit.javascript.host.css.CSSGroupingRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSGroupingRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSGroupingRule)WrappedObject; }
      }

      public CSSGroupingRule()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSGroupingRule()) {}

   }


}
