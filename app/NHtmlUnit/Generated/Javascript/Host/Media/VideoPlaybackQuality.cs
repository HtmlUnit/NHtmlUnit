// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class VideoPlaybackQuality : NHtmlUnit.Javascript.SimpleScriptable
   {
      static VideoPlaybackQuality()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.VideoPlaybackQuality o) =>
            new VideoPlaybackQuality(o));
      }

      public VideoPlaybackQuality(com.gargoylesoftware.htmlunit.javascript.host.media.VideoPlaybackQuality wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.VideoPlaybackQuality WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.VideoPlaybackQuality)WrappedObject; }
      }

      public VideoPlaybackQuality()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.VideoPlaybackQuality()) {}

   }


}
