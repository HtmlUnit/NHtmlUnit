// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSS : NHtmlUnit.Javascript.SimpleScriptable
   {
      static CSS()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSS o) =>
            new CSS(o));
      }

      public CSS(com.gargoylesoftware.htmlunit.javascript.host.css.CSS wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSS WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSS)WrappedObject; }
      }

      public CSS()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSS()) {}

   }


}
