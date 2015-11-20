// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class OscillatorNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static OscillatorNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.OscillatorNode o) =>
            new OscillatorNode(o));
      }

      public OscillatorNode(com.gargoylesoftware.htmlunit.javascript.host.media.OscillatorNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.OscillatorNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.OscillatorNode)WrappedObject; }
      }

      public OscillatorNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.OscillatorNode()) {}

   }


}
