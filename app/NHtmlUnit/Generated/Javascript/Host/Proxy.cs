// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Proxy : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Proxy()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Proxy o) =>
            new Proxy(o));
      }

      public Proxy(com.gargoylesoftware.htmlunit.javascript.host.Proxy wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Proxy WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Proxy)WrappedObject; }
      }

      public Proxy()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Proxy()) {}

   }


}
