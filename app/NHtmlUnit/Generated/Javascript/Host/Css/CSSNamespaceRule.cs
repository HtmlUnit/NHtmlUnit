// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSNamespaceRule : NHtmlUnit.Javascript.Host.Css.CSSRule
   {
      static CSSNamespaceRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSNamespaceRule o) =>
            new CSSNamespaceRule(o));
      }

      public CSSNamespaceRule(com.gargoylesoftware.htmlunit.javascript.host.css.CSSNamespaceRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSNamespaceRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSNamespaceRule)WrappedObject; }
      }

      public CSSNamespaceRule()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSNamespaceRule()) {}

   }


}
