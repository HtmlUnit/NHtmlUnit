// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class AudioContext : NHtmlUnit.Javascript.Host.Media.BaseAudioContext
   {
      static AudioContext()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.AudioContext o) =>
            new AudioContext(o));
      }

      public AudioContext(com.gargoylesoftware.htmlunit.javascript.host.media.AudioContext wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.AudioContext WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.AudioContext)WrappedObject; }
      }

      public AudioContext()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.AudioContext()) {}

// Generating method code for decodeAudioData
      public virtual NHtmlUnit.Javascript.Host.Promise DecodeAudioData(net.sourceforge.htmlunit.corejs.javascript.typedarrays.NativeArrayBuffer buffer, net.sourceforge.htmlunit.corejs.javascript.Function success, net.sourceforge.htmlunit.corejs.javascript.Function error)
      {
         var arg = WObj.decodeAudioData(buffer, success, error);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Promise>(arg);
      }

// Generating method code for createGain
      public virtual NHtmlUnit.Javascript.Host.Media.GainNode CreateGain()
      {
         var arg = WObj.createGain();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Media.GainNode>(arg);
      }

   }


}
