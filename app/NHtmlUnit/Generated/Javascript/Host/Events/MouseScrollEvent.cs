// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MouseScrollEvent : NHtmlUnit.Javascript.Host.Events.MouseEvent
   {
      static MouseScrollEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MouseScrollEvent o) =>
            new MouseScrollEvent(o));
      }

      public MouseScrollEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MouseScrollEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MouseScrollEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MouseScrollEvent)WrappedObject; }
      }

      public MouseScrollEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MouseScrollEvent()) {}

   }


}
