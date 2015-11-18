// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class ConvolverNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static ConvolverNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.ConvolverNode o) =>
            new ConvolverNode(o));
      }

      public ConvolverNode(com.gargoylesoftware.htmlunit.javascript.host.media.ConvolverNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.ConvolverNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.ConvolverNode)WrappedObject; }
      }

      public ConvolverNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.ConvolverNode()) {}

   }


}
