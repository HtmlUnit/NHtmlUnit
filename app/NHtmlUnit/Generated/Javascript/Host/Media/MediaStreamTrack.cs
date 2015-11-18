// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class MediaStreamTrack : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static MediaStreamTrack()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.MediaStreamTrack o) =>
            new MediaStreamTrack(o));
      }

      public MediaStreamTrack(com.gargoylesoftware.htmlunit.javascript.host.media.MediaStreamTrack wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.MediaStreamTrack WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.MediaStreamTrack)WrappedObject; }
      }

      public MediaStreamTrack()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.MediaStreamTrack()) {}

   }


}
