// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class MediaDeviceInfo : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MediaDeviceInfo()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.MediaDeviceInfo o) =>
            new MediaDeviceInfo(o));
      }

      public MediaDeviceInfo(com.gargoylesoftware.htmlunit.javascript.host.media.MediaDeviceInfo wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.MediaDeviceInfo WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.MediaDeviceInfo)WrappedObject; }
      }

      public MediaDeviceInfo()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.MediaDeviceInfo()) {}

   }


}
