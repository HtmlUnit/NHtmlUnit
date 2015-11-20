// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSS2Properties : NHtmlUnit.Javascript.Host.Css.ComputedCSSStyleDeclaration, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static CSS2Properties()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSS2Properties o) =>
            new CSS2Properties(o));
      }

      public CSS2Properties(com.gargoylesoftware.htmlunit.javascript.host.css.CSS2Properties wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSS2Properties WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSS2Properties)WrappedObject; }
      }

      public CSS2Properties()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSS2Properties()) {}

      public CSS2Properties(NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration style)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSS2Properties((com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleDeclaration)style.WrappedObject)) {}

   }


}
