// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MediaStreamEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static MediaStreamEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MediaStreamEvent o) =>
            new MediaStreamEvent(o));
      }

      public MediaStreamEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MediaStreamEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MediaStreamEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MediaStreamEvent)WrappedObject; }
      }

      public MediaStreamEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MediaStreamEvent()) {}

   }


}
