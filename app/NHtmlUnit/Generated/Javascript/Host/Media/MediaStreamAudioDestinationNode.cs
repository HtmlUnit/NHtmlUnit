// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class MediaStreamAudioDestinationNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static MediaStreamAudioDestinationNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.MediaStreamAudioDestinationNode o) =>
            new MediaStreamAudioDestinationNode(o));
      }

      public MediaStreamAudioDestinationNode(com.gargoylesoftware.htmlunit.javascript.host.media.MediaStreamAudioDestinationNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.MediaStreamAudioDestinationNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.MediaStreamAudioDestinationNode)WrappedObject; }
      }

      public MediaStreamAudioDestinationNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.MediaStreamAudioDestinationNode()) {}

   }


}
