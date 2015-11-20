// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class WaveShaperNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static WaveShaperNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.WaveShaperNode o) =>
            new WaveShaperNode(o));
      }

      public WaveShaperNode(com.gargoylesoftware.htmlunit.javascript.host.media.WaveShaperNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.WaveShaperNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.WaveShaperNode)WrappedObject; }
      }

      public WaveShaperNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.WaveShaperNode()) {}

   }


}
