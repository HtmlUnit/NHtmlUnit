// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MediaKeyMessageEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static MediaKeyMessageEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MediaKeyMessageEvent o) =>
            new MediaKeyMessageEvent(o));
      }

      public MediaKeyMessageEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MediaKeyMessageEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MediaKeyMessageEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MediaKeyMessageEvent)WrappedObject; }
      }

      public MediaKeyMessageEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MediaKeyMessageEvent()) {}

   }


}
