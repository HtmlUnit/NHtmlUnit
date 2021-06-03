// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Rtc
{
   public partial class WebkitRTCPeerConnection : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static WebkitRTCPeerConnection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.rtc.WebkitRTCPeerConnection o) =>
            new WebkitRTCPeerConnection(o));
      }

      public WebkitRTCPeerConnection(com.gargoylesoftware.htmlunit.javascript.host.media.rtc.WebkitRTCPeerConnection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.WebkitRTCPeerConnection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.rtc.WebkitRTCPeerConnection)WrappedObject; }
      }

      public WebkitRTCPeerConnection()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.WebkitRTCPeerConnection()) {}

   }


}
