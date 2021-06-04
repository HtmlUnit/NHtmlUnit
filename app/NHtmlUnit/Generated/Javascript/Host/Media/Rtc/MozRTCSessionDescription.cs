// Generated class v2.50.0.0, don't modify

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
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.rtc.MozRTCSessionDescription o) =>
            new MozRTCSessionDescription(o));
      }

      public MozRTCSessionDescription(com.gargoylesoftware.htmlunit.javascript.host.media.rtc.MozRTCSessionDescription wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.MozRTCSessionDescription WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.rtc.MozRTCSessionDescription)WrappedObject; }
      }

      public MozRTCSessionDescription()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.rtc.MozRTCSessionDescription()) {}

   }


}
