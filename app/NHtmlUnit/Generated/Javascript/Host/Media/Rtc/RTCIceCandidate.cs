// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Rtc
{
   public partial class RTCIceCandidate : NHtmlUnit.Javascript.SimpleScriptable
   {
      static RTCIceCandidate()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCIceCandidate o) =>
            new RTCIceCandidate(o));
      }

      public RTCIceCandidate(com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCIceCandidate wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCIceCandidate WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCIceCandidate)WrappedObject; }
      }

      public RTCIceCandidate()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCIceCandidate()) {}

   }


}
