// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class AudioBuffer : NHtmlUnit.Javascript.SimpleScriptable
   {
      static AudioBuffer()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.AudioBuffer o) =>
            new AudioBuffer(o));
      }

      public AudioBuffer(com.gargoylesoftware.htmlunit.javascript.host.media.AudioBuffer wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.AudioBuffer WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.AudioBuffer)WrappedObject; }
      }

      public AudioBuffer()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.AudioBuffer()) {}

   }


}
