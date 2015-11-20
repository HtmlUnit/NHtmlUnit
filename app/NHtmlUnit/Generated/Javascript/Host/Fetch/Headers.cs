// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Fetch
{
   public partial class Headers : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Headers()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.fetch.Headers o) =>
            new Headers(o));
      }

      public Headers(com.gargoylesoftware.htmlunit.javascript.host.fetch.Headers wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.fetch.Headers WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.fetch.Headers)WrappedObject; }
      }

      public Headers()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.fetch.Headers()) {}

   }


}
