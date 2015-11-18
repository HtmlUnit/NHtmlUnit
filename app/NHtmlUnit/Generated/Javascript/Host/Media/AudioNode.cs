// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class AudioNode : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static AudioNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.AudioNode o) =>
            new AudioNode(o));
      }

      public AudioNode(com.gargoylesoftware.htmlunit.javascript.host.media.AudioNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.AudioNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.AudioNode)WrappedObject; }
      }

      public AudioNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.AudioNode()) {}

   }


}
