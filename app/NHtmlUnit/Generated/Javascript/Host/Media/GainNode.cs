// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class GainNode : NHtmlUnit.Javascript.Host.Media.AudioNode
   {
      static GainNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.GainNode o) =>
            new GainNode(o));
      }

      public GainNode(com.gargoylesoftware.htmlunit.javascript.host.media.GainNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.GainNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.GainNode)WrappedObject; }
      }

      public GainNode()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.GainNode()) {}


      public NHtmlUnit.Javascript.Host.Media.AudioParam Gain
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Media.AudioParam>(
               WObj.getGain());
         }
      }

// Generating method code for jsConstructor
      public virtual void JsConstructor(object baCtx)
      {
         WObj.jsConstructor(baCtx);
      }

   }


}
