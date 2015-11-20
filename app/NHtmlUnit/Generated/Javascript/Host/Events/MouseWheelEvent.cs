// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MouseWheelEvent : NHtmlUnit.Javascript.Host.Events.UIEvent
   {
      static MouseWheelEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MouseWheelEvent o) =>
            new MouseWheelEvent(o));
      }

      public MouseWheelEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MouseWheelEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MouseWheelEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MouseWheelEvent)WrappedObject; }
      }

      public MouseWheelEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MouseWheelEvent()) {}

   }


}
