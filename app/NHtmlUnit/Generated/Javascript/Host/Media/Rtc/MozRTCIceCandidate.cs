// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Rtc
{
   public partial class MozRTCIceCandidate : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MozRTCIceCandidate()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.rtc.mozRTCIceCandidate o) =>
            new MozRTCIceCandidate(o));
      }

      public MozRTCIceCandidate(com.gargoylesoftware.htmlunit.javascript.host.media.rtc.mozRTCIceCandidate wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.mozRTCIceCandidate WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.rtc.mozRTCIceCandidate)WrappedObject; }
      }

      public MozRTCIceCandidate()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.mozRTCIceCandidate()) {}

   }


}
