// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class RTCPeerConnectionIceEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static RTCPeerConnectionIceEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.RTCPeerConnectionIceEvent o) =>
            new RTCPeerConnectionIceEvent(o));
      }

      public RTCPeerConnectionIceEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.RTCPeerConnectionIceEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.RTCPeerConnectionIceEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.RTCPeerConnectionIceEvent)WrappedObject; }
      }

      public RTCPeerConnectionIceEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.RTCPeerConnectionIceEvent()) {}

   }


}
