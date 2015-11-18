// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class TransitionEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static TransitionEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.TransitionEvent o) =>
            new TransitionEvent(o));
      }

      public TransitionEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.TransitionEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.TransitionEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.TransitionEvent)WrappedObject; }
      }

      public TransitionEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.TransitionEvent()) {}

   }


}
