// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class DelayNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static DelayNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.DelayNode o) =>
            new DelayNode(o));
      }

      public DelayNode(com.gargoylesoftware.htmlunit.javascript.host.media.DelayNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.DelayNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.DelayNode)WrappedObject; }
      }

      public DelayNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.DelayNode()) {}

   }


}
