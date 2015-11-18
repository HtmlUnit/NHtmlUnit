// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSPageRule : NHtmlUnit.Javascript.Host.Css.CSSRule
   {
      static CSSPageRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSPageRule o) =>
            new CSSPageRule(o));
      }

      public CSSPageRule(com.gargoylesoftware.htmlunit.javascript.host.css.CSSPageRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSPageRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSPageRule)WrappedObject; }
      }

      public CSSPageRule()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSPageRule()) {}

   }


}
