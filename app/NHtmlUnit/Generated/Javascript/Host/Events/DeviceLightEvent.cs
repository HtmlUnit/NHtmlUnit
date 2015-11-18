// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class DeviceLightEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static DeviceLightEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceLightEvent o) =>
            new DeviceLightEvent(o));
      }

      public DeviceLightEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceLightEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceLightEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceLightEvent)WrappedObject; }
      }

      public DeviceLightEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceLightEvent()) {}

   }


}
