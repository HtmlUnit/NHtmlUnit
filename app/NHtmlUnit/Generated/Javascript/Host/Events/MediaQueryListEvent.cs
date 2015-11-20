// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MediaQueryListEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static MediaQueryListEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MediaQueryListEvent o) =>
            new MediaQueryListEvent(o));
      }

      public MediaQueryListEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MediaQueryListEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MediaQueryListEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MediaQueryListEvent)WrappedObject; }
      }

      public MediaQueryListEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MediaQueryListEvent()) {}

   }


}
