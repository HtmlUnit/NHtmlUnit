// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class TrackEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static TrackEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.TrackEvent o) =>
            new TrackEvent(o));
      }

      public TrackEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.TrackEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.TrackEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.TrackEvent)WrappedObject; }
      }

      public TrackEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.TrackEvent()) {}

   }


}
