// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class AnalyserNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static AnalyserNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.AnalyserNode o) =>
            new AnalyserNode(o));
      }

      public AnalyserNode(com.gargoylesoftware.htmlunit.javascript.host.media.AnalyserNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.AnalyserNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.AnalyserNode)WrappedObject; }
      }

      public AnalyserNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.AnalyserNode()) {}

   }


}
