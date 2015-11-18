// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class MediaDevices : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static MediaDevices()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.MediaDevices o) =>
            new MediaDevices(o));
      }

      public MediaDevices(com.gargoylesoftware.htmlunit.javascript.host.media.MediaDevices wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.MediaDevices WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.MediaDevices)WrappedObject; }
      }

      public MediaDevices()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.MediaDevices()) {}

   }


}
