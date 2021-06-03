// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class AudioScheduledSourceNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static AudioScheduledSourceNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.AudioScheduledSourceNode o) =>
            new AudioScheduledSourceNode(o));
      }

      public AudioScheduledSourceNode(com.gargoylesoftware.htmlunit.javascript.host.AudioScheduledSourceNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.AudioScheduledSourceNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.AudioScheduledSourceNode)WrappedObject; }
      }

      public AudioScheduledSourceNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.AudioScheduledSourceNode()) {}

   }


}
