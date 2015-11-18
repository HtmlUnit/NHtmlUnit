// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class StereoPannerNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static StereoPannerNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.StereoPannerNode o) =>
            new StereoPannerNode(o));
      }

      public StereoPannerNode(com.gargoylesoftware.htmlunit.javascript.host.media.StereoPannerNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.StereoPannerNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.StereoPannerNode)WrappedObject; }
      }

      public StereoPannerNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.StereoPannerNode()) {}

   }


}
