// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class DynamicsCompressorNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static DynamicsCompressorNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.DynamicsCompressorNode o) =>
            new DynamicsCompressorNode(o));
      }

      public DynamicsCompressorNode(com.gargoylesoftware.htmlunit.javascript.host.media.DynamicsCompressorNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.DynamicsCompressorNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.DynamicsCompressorNode)WrappedObject; }
      }

      public DynamicsCompressorNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.DynamicsCompressorNode()) {}

   }


}
