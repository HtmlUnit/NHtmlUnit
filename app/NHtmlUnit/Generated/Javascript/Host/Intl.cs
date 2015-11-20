// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Intl
{
   public partial class Intl : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Intl()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.intl.Intl o) =>
            new Intl(o));
      }

      public Intl(com.gargoylesoftware.htmlunit.javascript.host.intl.Intl wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.intl.Intl WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.intl.Intl)WrappedObject; }
      }

      public Intl()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.intl.Intl()) {}

// Generating method code for defineProperties
      public virtual void DefineProperties(NHtmlUnit.BrowserVersion browserVersion)
      {
         WObj.defineProperties((com.gargoylesoftware.htmlunit.BrowserVersion)browserVersion.WrappedObject);
      }

   }


}
