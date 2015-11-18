// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class BatteryManager : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static BatteryManager()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.BatteryManager o) =>
            new BatteryManager(o));
      }

      public BatteryManager(com.gargoylesoftware.htmlunit.javascript.host.BatteryManager wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.BatteryManager WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.BatteryManager)WrappedObject; }
      }

      public BatteryManager()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.BatteryManager()) {}

   }


}
