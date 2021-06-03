// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MediaStreamTrackEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static MediaStreamTrackEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MediaStreamTrackEvent o) =>
            new MediaStreamTrackEvent(o));
      }

      public MediaStreamTrackEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MediaStreamTrackEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MediaStreamTrackEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MediaStreamTrackEvent)WrappedObject; }
      }

      public MediaStreamTrackEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MediaStreamTrackEvent()) {}

   }


}
