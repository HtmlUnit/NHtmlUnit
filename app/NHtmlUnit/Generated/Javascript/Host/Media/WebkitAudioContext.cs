// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class WebkitAudioContext : NHtmlUnit.Javascript.Host.Media.AudioContext
   {
      static WebkitAudioContext()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.webkitAudioContext o) =>
            new WebkitAudioContext(o));
      }

      public WebkitAudioContext(com.gargoylesoftware.htmlunit.javascript.host.media.webkitAudioContext wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.webkitAudioContext WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.webkitAudioContext)WrappedObject; }
      }

      public WebkitAudioContext()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.webkitAudioContext()) {}

   }


}
