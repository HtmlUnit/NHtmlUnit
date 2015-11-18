// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class PannerNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static PannerNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.PannerNode o) =>
            new PannerNode(o));
      }

      public PannerNode(com.gargoylesoftware.htmlunit.javascript.host.media.PannerNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.PannerNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.PannerNode)WrappedObject; }
      }

      public PannerNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.PannerNode()) {}

   }


}
