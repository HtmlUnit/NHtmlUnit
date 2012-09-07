// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class WebSocket : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebSocket()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.WebSocket o) =>
            new WebSocket(o));
      }

      public WebSocket(com.gargoylesoftware.htmlunit.javascript.host.WebSocket wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.WebSocket WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.WebSocket)WrappedObject; }
      }

      public WebSocket()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.WebSocket()) {}

   }


}
