// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class OfflineAudioContext : NHtmlUnit.Javascript.Host.Media.BaseAudioContext
   {
      static OfflineAudioContext()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.OfflineAudioContext o) =>
            new OfflineAudioContext(o));
      }

      public OfflineAudioContext(com.gargoylesoftware.htmlunit.javascript.host.media.OfflineAudioContext wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.OfflineAudioContext WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.OfflineAudioContext)WrappedObject; }
      }

      public OfflineAudioContext()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.OfflineAudioContext()) {}

// Generating method code for startRendering
      public virtual void StartRendering()
      {
         WObj.startRendering();
      }

   }


}
