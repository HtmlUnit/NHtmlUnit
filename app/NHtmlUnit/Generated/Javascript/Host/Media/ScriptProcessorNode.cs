// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class ScriptProcessorNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static ScriptProcessorNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.ScriptProcessorNode o) =>
            new ScriptProcessorNode(o));
      }

      public ScriptProcessorNode(com.gargoylesoftware.htmlunit.javascript.host.media.ScriptProcessorNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.ScriptProcessorNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.ScriptProcessorNode)WrappedObject; }
      }

      public ScriptProcessorNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.ScriptProcessorNode()) {}

   }


}
