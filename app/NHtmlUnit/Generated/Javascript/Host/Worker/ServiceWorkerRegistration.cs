// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Worker
{
   public partial class ServiceWorkerRegistration : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static ServiceWorkerRegistration()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.worker.ServiceWorkerRegistration o) =>
            new ServiceWorkerRegistration(o));
      }

      public ServiceWorkerRegistration(com.gargoylesoftware.htmlunit.javascript.host.worker.ServiceWorkerRegistration wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.worker.ServiceWorkerRegistration WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.worker.ServiceWorkerRegistration)WrappedObject; }
      }

      public ServiceWorkerRegistration()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.worker.ServiceWorkerRegistration()) {}

   }


}
