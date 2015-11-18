// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class AudioListener : NHtmlUnit.Javascript.SimpleScriptable
   {
      static AudioListener()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.AudioListener o) =>
            new AudioListener(o));
      }

      public AudioListener(com.gargoylesoftware.htmlunit.javascript.host.media.AudioListener wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.AudioListener WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.AudioListener)WrappedObject; }
      }

      public AudioListener()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.AudioListener()) {}

   }


}
