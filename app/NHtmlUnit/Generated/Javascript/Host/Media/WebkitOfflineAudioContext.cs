// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class WebkitOfflineAudioContext : NHtmlUnit.Javascript.Host.Media.OfflineAudioContext
   {
      static WebkitOfflineAudioContext()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.webkitOfflineAudioContext o) =>
            new WebkitOfflineAudioContext(o));
      }

      public WebkitOfflineAudioContext(com.gargoylesoftware.htmlunit.javascript.host.media.webkitOfflineAudioContext wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.webkitOfflineAudioContext WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.webkitOfflineAudioContext)WrappedObject; }
      }

      public WebkitOfflineAudioContext()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.webkitOfflineAudioContext()) {}

   }


}
