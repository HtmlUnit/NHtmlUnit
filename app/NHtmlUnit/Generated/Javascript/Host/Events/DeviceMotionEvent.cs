// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class DeviceMotionEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static DeviceMotionEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceMotionEvent o) =>
            new DeviceMotionEvent(o));
      }

      public DeviceMotionEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceMotionEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceMotionEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceMotionEvent)WrappedObject; }
      }

      public DeviceMotionEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceMotionEvent()) {}

   }


}
