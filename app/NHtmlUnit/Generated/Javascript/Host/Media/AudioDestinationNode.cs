// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class AudioDestinationNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static AudioDestinationNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.AudioDestinationNode o) =>
            new AudioDestinationNode(o));
      }

      public AudioDestinationNode(com.gargoylesoftware.htmlunit.javascript.host.media.AudioDestinationNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.AudioDestinationNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.AudioDestinationNode)WrappedObject; }
      }

      public AudioDestinationNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.AudioDestinationNode()) {}

   }


}
