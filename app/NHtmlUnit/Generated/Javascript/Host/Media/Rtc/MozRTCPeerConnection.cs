// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Rtc
{
   public partial class MozRTCPeerConnection : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static MozRTCPeerConnection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.rtc.MozRTCPeerConnection o) =>
            new MozRTCPeerConnection(o));
      }

      public MozRTCPeerConnection(com.gargoylesoftware.htmlunit.javascript.host.media.rtc.MozRTCPeerConnection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.MozRTCPeerConnection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.rtc.MozRTCPeerConnection)WrappedObject; }
      }

      public MozRTCPeerConnection()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.MozRTCPeerConnection()) {}

   }


}
