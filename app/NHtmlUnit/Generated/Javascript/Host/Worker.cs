// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Worker
{
   public partial class Worker : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static Worker()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.worker.Worker o) =>
            new Worker(o));
      }

      public Worker(com.gargoylesoftware.htmlunit.javascript.host.worker.Worker wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.worker.Worker WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.worker.Worker)WrappedObject; }
      }

      public Worker()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.worker.Worker()) {}


      public System.Object Onmessage
      {
         get
         {
            return WObj.getOnmessage();
         }
         set
         {
            WObj.setOnmessage(value);
         }

      }
// Generating method code for postMessage
      public virtual void PostMessage(object message)
      {
         WObj.postMessage(message);
      }

   }


}
