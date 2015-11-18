// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class DeviceStorage : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static DeviceStorage()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.DeviceStorage o) =>
            new DeviceStorage(o));
      }

      public DeviceStorage(com.gargoylesoftware.htmlunit.javascript.host.DeviceStorage wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.DeviceStorage WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.DeviceStorage)WrappedObject; }
      }

      public DeviceStorage()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.DeviceStorage()) {}

   }


}
