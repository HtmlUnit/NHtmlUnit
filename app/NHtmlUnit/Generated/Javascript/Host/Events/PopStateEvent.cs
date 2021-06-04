// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class PopStateEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static PopStateEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.PopStateEvent o) =>
            new PopStateEvent(o));
      }

      public PopStateEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.PopStateEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.PopStateEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.PopStateEvent)WrappedObject; }
      }

      public PopStateEvent(NHtmlUnit.Javascript.Host.Events.EventTarget target, string type, object state)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.PopStateEvent((com.gargoylesoftware.htmlunit.javascript.host.@event.EventTarget)target.WrappedObject, type, state)) {}

      public PopStateEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.PopStateEvent()) {}


      public System.Object State
      {
         get
         {
            return WObj.getState();
         }
      }
// Generating method code for initPopStateEvent
      public virtual void InitPopStateEvent(string type, bool bubbles, bool cancelable, object state)
      {
         WObj.initPopStateEvent(type, bubbles, cancelable, state);
      }

   }


}
