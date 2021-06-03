// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class PromiseRejectionEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static PromiseRejectionEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.PromiseRejectionEvent o) =>
            new PromiseRejectionEvent(o));
      }

      public PromiseRejectionEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.PromiseRejectionEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.PromiseRejectionEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.PromiseRejectionEvent)WrappedObject; }
      }

      public PromiseRejectionEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.PromiseRejectionEvent()) {}

   }


}
