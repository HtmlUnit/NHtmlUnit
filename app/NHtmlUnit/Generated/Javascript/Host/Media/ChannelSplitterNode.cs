// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class ChannelSplitterNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static ChannelSplitterNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.ChannelSplitterNode o) =>
            new ChannelSplitterNode(o));
      }

      public ChannelSplitterNode(com.gargoylesoftware.htmlunit.javascript.host.media.ChannelSplitterNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.ChannelSplitterNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.ChannelSplitterNode)WrappedObject; }
      }

      public ChannelSplitterNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.ChannelSplitterNode()) {}

   }


}
