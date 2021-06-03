// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class PresentationConnectionAvailableEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static PresentationConnectionAvailableEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.PresentationConnectionAvailableEvent o) =>
            new PresentationConnectionAvailableEvent(o));
      }

      public PresentationConnectionAvailableEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.PresentationConnectionAvailableEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.PresentationConnectionAvailableEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.PresentationConnectionAvailableEvent)WrappedObject; }
      }

      public PresentationConnectionAvailableEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.PresentationConnectionAvailableEvent()) {}

   }


}
