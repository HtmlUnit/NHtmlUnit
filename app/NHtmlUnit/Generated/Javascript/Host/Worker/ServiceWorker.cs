// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Worker
{
   public partial class ServiceWorker : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static ServiceWorker()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.worker.ServiceWorker o) =>
            new ServiceWorker(o));
      }

      public ServiceWorker(com.gargoylesoftware.htmlunit.javascript.host.worker.ServiceWorker wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.worker.ServiceWorker WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.worker.ServiceWorker)WrappedObject; }
      }

      public ServiceWorker()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.worker.ServiceWorker()) {}

   }


}
