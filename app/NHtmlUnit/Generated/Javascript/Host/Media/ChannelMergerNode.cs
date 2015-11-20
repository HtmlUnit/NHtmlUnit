// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class ChannelMergerNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static ChannelMergerNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.ChannelMergerNode o) =>
            new ChannelMergerNode(o));
      }

      public ChannelMergerNode(com.gargoylesoftware.htmlunit.javascript.host.media.ChannelMergerNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.ChannelMergerNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.ChannelMergerNode)WrappedObject; }
      }

      public ChannelMergerNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.ChannelMergerNode()) {}

   }


}
