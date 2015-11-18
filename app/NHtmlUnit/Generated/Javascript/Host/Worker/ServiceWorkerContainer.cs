// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Worker
{
   public partial class ServiceWorkerContainer : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static ServiceWorkerContainer()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.worker.ServiceWorkerContainer o) =>
            new ServiceWorkerContainer(o));
      }

      public ServiceWorkerContainer(com.gargoylesoftware.htmlunit.javascript.host.worker.ServiceWorkerContainer wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.worker.ServiceWorkerContainer WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.worker.ServiceWorkerContainer)WrappedObject; }
      }

      public ServiceWorkerContainer()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.worker.ServiceWorkerContainer()) {}

   }


}
