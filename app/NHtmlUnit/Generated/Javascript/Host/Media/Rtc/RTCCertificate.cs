// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Rtc
{
   public partial class RTCCertificate : NHtmlUnit.Javascript.SimpleScriptable
   {
      static RTCCertificate()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCCertificate o) =>
            new RTCCertificate(o));
      }

      public RTCCertificate(com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCCertificate wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCCertificate WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCCertificate)WrappedObject; }
      }

      public RTCCertificate()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCCertificate()) {}

   }


}
