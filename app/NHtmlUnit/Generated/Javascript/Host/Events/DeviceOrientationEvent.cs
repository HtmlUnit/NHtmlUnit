// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class DeviceOrientationEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static DeviceOrientationEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceOrientationEvent o) =>
            new DeviceOrientationEvent(o));
      }

      public DeviceOrientationEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceOrientationEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceOrientationEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceOrientationEvent)WrappedObject; }
      }

      public DeviceOrientationEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceOrientationEvent()) {}

   }


}
