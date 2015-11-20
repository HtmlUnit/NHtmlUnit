// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class TextTrackCue : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static TextTrackCue()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.TextTrackCue o) =>
            new TextTrackCue(o));
      }

      public TextTrackCue(com.gargoylesoftware.htmlunit.javascript.host.media.TextTrackCue wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.TextTrackCue WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.TextTrackCue)WrappedObject; }
      }

      public TextTrackCue()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.TextTrackCue()) {}

   }


}
