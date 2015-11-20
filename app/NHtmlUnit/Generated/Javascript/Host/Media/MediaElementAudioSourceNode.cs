// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class MediaElementAudioSourceNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static MediaElementAudioSourceNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.MediaElementAudioSourceNode o) =>
            new MediaElementAudioSourceNode(o));
      }

      public MediaElementAudioSourceNode(com.gargoylesoftware.htmlunit.javascript.host.media.MediaElementAudioSourceNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.MediaElementAudioSourceNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.MediaElementAudioSourceNode)WrappedObject; }
      }

      public MediaElementAudioSourceNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.MediaElementAudioSourceNode()) {}

   }


}
