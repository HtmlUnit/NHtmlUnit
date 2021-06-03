// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Rtc
{
   public partial class RTCPeerConnection : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static RTCPeerConnection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCPeerConnection o) =>
            new RTCPeerConnection(o));
      }

      public RTCPeerConnection(com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCPeerConnection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCPeerConnection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCPeerConnection)WrappedObject; }
      }

      public RTCPeerConnection()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCPeerConnection()) {}

   }


}
