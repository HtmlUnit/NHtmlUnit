// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Worker
{
   public partial class DedicatedWorkerGlobalScope : NHtmlUnit.Javascript.Host.Events.EventTarget, NHtmlUnit.Javascript.Host.IWindowOrWorkerGlobalScope
   {
      static DedicatedWorkerGlobalScope()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.worker.DedicatedWorkerGlobalScope o) =>
            new DedicatedWorkerGlobalScope(o));
      }

      public DedicatedWorkerGlobalScope(com.gargoylesoftware.htmlunit.javascript.host.worker.DedicatedWorkerGlobalScope wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.worker.DedicatedWorkerGlobalScope WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.worker.DedicatedWorkerGlobalScope)WrappedObject; }
      }

      public DedicatedWorkerGlobalScope()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.worker.DedicatedWorkerGlobalScope()) {}


      public System.Object Self
      {
         get
         {
            return WObj.getSelf();
         }
      }
// Generating method code for btoa
      public virtual string Btoa(string stringToEncode)
      {
         return WObj.btoa(stringToEncode);
      }

// Generating method code for atob
      public virtual string Atob(string encodedData)
      {
         return WObj.atob(encodedData);
      }

// Generating method code for postMessage
      public virtual void PostMessage(object message)
      {
         WObj.postMessage(message);
      }

// Generating method code for getOnmessage
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmessage()
      {
         return WObj.getOnmessage();
      }

// Generating method code for setOnmessage
      public virtual void SetOnmessage(object onmessage)
      {
         WObj.setOnmessage(onmessage);
      }

   }


}
