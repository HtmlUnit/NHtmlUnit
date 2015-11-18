// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class TouchEvent : NHtmlUnit.Javascript.Host.Events.UIEvent
   {
      static TouchEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.TouchEvent o) =>
            new TouchEvent(o));
      }

      public TouchEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.TouchEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.TouchEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.TouchEvent)WrappedObject; }
      }

      public TouchEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.TouchEvent()) {}

   }


}
