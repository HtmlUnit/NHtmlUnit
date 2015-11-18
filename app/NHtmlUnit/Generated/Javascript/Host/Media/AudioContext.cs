// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class AudioContext : NHtmlUnit.Javascript.Host.Events.EventTarget
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

   }


}
