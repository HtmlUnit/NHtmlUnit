// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class ConstantSourceNode : NHtmlUnit.Javascript.Host.AudioScheduledSourceNode
   {
      static ConstantSourceNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.ConstantSourceNode o) =>
            new ConstantSourceNode(o));
      }

      public ConstantSourceNode(com.gargoylesoftware.htmlunit.javascript.host.media.ConstantSourceNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.ConstantSourceNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.ConstantSourceNode)WrappedObject; }
      }

      public ConstantSourceNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.ConstantSourceNode()) {}

   }


}
