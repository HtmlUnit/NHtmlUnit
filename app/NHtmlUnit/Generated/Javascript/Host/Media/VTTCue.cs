// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class VTTCue : NHtmlUnit.Javascript.Host.Media.TextTrackCue
   {
      static VTTCue()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.VTTCue o) =>
            new VTTCue(o));
      }

      public VTTCue(com.gargoylesoftware.htmlunit.javascript.host.media.VTTCue wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.VTTCue WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.VTTCue)WrappedObject; }
      }

      public VTTCue()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.VTTCue()) {}

   }


}
