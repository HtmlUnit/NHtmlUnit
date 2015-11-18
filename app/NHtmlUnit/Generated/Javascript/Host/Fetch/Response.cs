// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Fetch
{
   public partial class Response : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Response()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.fetch.Response o) =>
            new Response(o));
      }

      public Response(com.gargoylesoftware.htmlunit.javascript.host.fetch.Response wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.fetch.Response WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.fetch.Response)WrappedObject; }
      }

      public Response()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.fetch.Response()) {}

   }


}
