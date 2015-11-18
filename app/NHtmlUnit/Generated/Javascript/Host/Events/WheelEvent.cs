// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class WheelEvent : NHtmlUnit.Javascript.Host.Events.MouseEvent
   {
      static WheelEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.WheelEvent o) =>
            new WheelEvent(o));
      }

      public WheelEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.WheelEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.WheelEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.WheelEvent)WrappedObject; }
      }

      public WheelEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.WheelEvent()) {}

   }


}
