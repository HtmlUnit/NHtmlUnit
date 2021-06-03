// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class WebClientInternals : ObjectWrapper
   {
      static WebClientInternals()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.WebClientInternals o) =>
            new WebClientInternals(o));
      }

      public WebClientInternals(com.gargoylesoftware.htmlunit.WebClientInternals wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.WebClientInternals WObj
      {
         get { return (com.gargoylesoftware.htmlunit.WebClientInternals)WrappedObject; }
      }

// Generating method code for created
      public virtual void Created(NHtmlUnit.Javascript.Host.WebSocket webSocket)
      {
         WObj.created((com.gargoylesoftware.htmlunit.javascript.host.WebSocket)webSocket.WrappedObject);
      }

// Generating method code for addListener
      public virtual void AddListener(com.gargoylesoftware.htmlunit.WebClientInternals.Listener listener)
      {
         WObj.addListener(listener);
      }

// Generating method code for removeListener
      public virtual void RemoveListener(com.gargoylesoftware.htmlunit.WebClientInternals.Listener listener)
      {
         WObj.removeListener(listener);
      }

   }


}
