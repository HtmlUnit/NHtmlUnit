// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class BiquadFilterNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static BiquadFilterNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.BiquadFilterNode o) =>
            new BiquadFilterNode(o));
      }

      public BiquadFilterNode(com.gargoylesoftware.htmlunit.javascript.host.media.BiquadFilterNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.BiquadFilterNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.BiquadFilterNode)WrappedObject; }
      }

      public BiquadFilterNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.BiquadFilterNode()) {}

   }


}
