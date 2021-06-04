// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Rtc
{
   public partial class RTCStatsReport : NHtmlUnit.Javascript.SimpleScriptable
   {
      static RTCStatsReport()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCStatsReport o) =>
            new RTCStatsReport(o));
      }

      public RTCStatsReport(com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCStatsReport wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCStatsReport WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCStatsReport)WrappedObject; }
      }

      public RTCStatsReport()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCStatsReport()) {}

   }


}
