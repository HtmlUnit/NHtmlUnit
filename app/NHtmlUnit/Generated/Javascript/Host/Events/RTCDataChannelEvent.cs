// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class RTCDataChannelEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static RTCDataChannelEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.RTCDataChannelEvent o) =>
            new RTCDataChannelEvent(o));
      }

      public RTCDataChannelEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.RTCDataChannelEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.RTCDataChannelEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.RTCDataChannelEvent)WrappedObject; }
      }

      public RTCDataChannelEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.RTCDataChannelEvent()) {}

   }


}
