// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class PresentationConnectionCloseEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static PresentationConnectionCloseEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.PresentationConnectionCloseEvent o) =>
            new PresentationConnectionCloseEvent(o));
      }

      public PresentationConnectionCloseEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.PresentationConnectionCloseEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.PresentationConnectionCloseEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.PresentationConnectionCloseEvent)WrappedObject; }
      }

      public PresentationConnectionCloseEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.PresentationConnectionCloseEvent()) {}

   }


}
