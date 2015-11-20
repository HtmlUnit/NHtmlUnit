// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MediaKeyEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static MediaKeyEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MediaKeyEvent o) =>
            new MediaKeyEvent(o));
      }

      public MediaKeyEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MediaKeyEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MediaKeyEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MediaKeyEvent)WrappedObject; }
      }

      public MediaKeyEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MediaKeyEvent()) {}

   }


}
