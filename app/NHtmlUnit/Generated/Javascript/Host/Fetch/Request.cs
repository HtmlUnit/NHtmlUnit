// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Fetch
{
   public partial class Request : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Request()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.fetch.Request o) =>
            new Request(o));
      }

      public Request(com.gargoylesoftware.htmlunit.javascript.host.fetch.Request wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.fetch.Request WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.fetch.Request)WrappedObject; }
      }

      public Request()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.fetch.Request()) {}

   }


}
