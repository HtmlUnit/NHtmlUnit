// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class AudioBufferSourceNode : NHtmlUnit.Javascript.Host.AudioScheduledSourceNode
   {
      static AudioBufferSourceNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.AudioBufferSourceNode o) =>
            new AudioBufferSourceNode(o));
      }

      public AudioBufferSourceNode(com.gargoylesoftware.htmlunit.javascript.host.media.AudioBufferSourceNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.AudioBufferSourceNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.AudioBufferSourceNode)WrappedObject; }
      }

      public AudioBufferSourceNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.AudioBufferSourceNode()) {}

// Generating method code for start
      public virtual void Start()
      {
         WObj.start();
      }

   }


}
