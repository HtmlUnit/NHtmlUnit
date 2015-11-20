// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class DeviceProximityEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static DeviceProximityEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceProximityEvent o) =>
            new DeviceProximityEvent(o));
      }

      public DeviceProximityEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceProximityEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceProximityEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceProximityEvent)WrappedObject; }
      }

      public DeviceProximityEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceProximityEvent()) {}

   }


}
