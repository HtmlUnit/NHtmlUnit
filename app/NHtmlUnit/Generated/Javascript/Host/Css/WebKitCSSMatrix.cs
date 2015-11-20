// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class WebKitCSSMatrix : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebKitCSSMatrix()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.WebKitCSSMatrix o) =>
            new WebKitCSSMatrix(o));
      }

      public WebKitCSSMatrix(com.gargoylesoftware.htmlunit.javascript.host.css.WebKitCSSMatrix wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.WebKitCSSMatrix WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.WebKitCSSMatrix)WrappedObject; }
      }

      public WebKitCSSMatrix()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.WebKitCSSMatrix()) {}

   }


}
