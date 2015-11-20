// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class DeviceStorageChangeEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static DeviceStorageChangeEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceStorageChangeEvent o) =>
            new DeviceStorageChangeEvent(o));
      }

      public DeviceStorageChangeEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceStorageChangeEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceStorageChangeEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceStorageChangeEvent)WrappedObject; }
      }

      public DeviceStorageChangeEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.DeviceStorageChangeEvent()) {}

   }


}
