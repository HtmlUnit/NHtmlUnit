// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class TimeEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static TimeEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.TimeEvent o) =>
            new TimeEvent(o));
      }

      public TimeEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.TimeEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.TimeEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.TimeEvent)WrappedObject; }
      }

      public TimeEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.TimeEvent()) {}

   }


}
