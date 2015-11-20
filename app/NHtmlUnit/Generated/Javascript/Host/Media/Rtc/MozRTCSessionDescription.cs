// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Rtc
{
   public partial class MozRTCSessionDescription : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MozRTCSessionDescription()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.rtc.mozRTCSessionDescription o) =>
            new MozRTCSessionDescription(o));
      }

      public MozRTCSessionDescription(com.gargoylesoftware.htmlunit.javascript.host.media.rtc.mozRTCSessionDescription wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.mozRTCSessionDescription WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.rtc.mozRTCSessionDescription)WrappedObject; }
      }

      public MozRTCSessionDescription()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.mozRTCSessionDescription()) {}

   }


}
