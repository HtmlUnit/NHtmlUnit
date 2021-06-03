// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class IIRFilterNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static IIRFilterNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.IIRFilterNode o) =>
            new IIRFilterNode(o));
      }

      public IIRFilterNode(com.gargoylesoftware.htmlunit.javascript.host.media.IIRFilterNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.IIRFilterNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.IIRFilterNode)WrappedObject; }
      }

      public IIRFilterNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.IIRFilterNode()) {}

   }


}
