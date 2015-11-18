// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Rtc
{
   public partial class RTCSessionDescription : NHtmlUnit.Javascript.SimpleScriptable
   {
      static RTCSessionDescription()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCSessionDescription o) =>
            new RTCSessionDescription(o));
      }

      public RTCSessionDescription(com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCSessionDescription wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCSessionDescription WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCSessionDescription)WrappedObject; }
      }

      public RTCSessionDescription()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.RTCSessionDescription()) {}

   }


}
