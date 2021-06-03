// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class BaseAudioContext : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static BaseAudioContext()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.BaseAudioContext o) =>
            new BaseAudioContext(o));
      }

      public BaseAudioContext(com.gargoylesoftware.htmlunit.javascript.host.media.BaseAudioContext wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.BaseAudioContext WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.BaseAudioContext)WrappedObject; }
      }

      public BaseAudioContext()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.BaseAudioContext()) {}

// Generating method code for createBufferSource
      public virtual NHtmlUnit.Javascript.Host.Media.AudioBufferSourceNode CreateBufferSource()
      {
         var arg = WObj.createBufferSource();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Media.AudioBufferSourceNode>(arg);
      }

// Generating method code for createBuffer
      public virtual NHtmlUnit.Javascript.Host.Media.AudioBuffer CreateBuffer()
      {
         var arg = WObj.createBuffer();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Media.AudioBuffer>(arg);
      }

   }


}
