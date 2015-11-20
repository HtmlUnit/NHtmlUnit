// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class ServiceWorkerMessageEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static ServiceWorkerMessageEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.ServiceWorkerMessageEvent o) =>
            new ServiceWorkerMessageEvent(o));
      }

      public ServiceWorkerMessageEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.ServiceWorkerMessageEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.ServiceWorkerMessageEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.ServiceWorkerMessageEvent)WrappedObject; }
      }

      public ServiceWorkerMessageEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.ServiceWorkerMessageEvent()) {}

   }


}
