// Generated class v2.13, don't modify

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


      public System.String Encoding
      {
         get
         {
            return WObj.getEncoding();
         }
         set
         {
            WObj.setEncoding(value);
         }

      }
   }


}
