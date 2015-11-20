// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class MediaStreamAudioSourceNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static MediaStreamAudioSourceNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.MediaStreamAudioSourceNode o) =>
            new MediaStreamAudioSourceNode(o));
      }

      public MediaStreamAudioSourceNode(com.gargoylesoftware.htmlunit.javascript.host.media.MediaStreamAudioSourceNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.MediaStreamAudioSourceNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.MediaStreamAudioSourceNode)WrappedObject; }
      }

      public MediaStreamAudioSourceNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.MediaStreamAudioSourceNode()) {}

   }


}
