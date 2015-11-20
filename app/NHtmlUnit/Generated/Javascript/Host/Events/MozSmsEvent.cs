// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MozSmsEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static MozSmsEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MozSmsEvent o) =>
            new MozSmsEvent(o));
      }

      public MozSmsEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MozSmsEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MozSmsEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MozSmsEvent)WrappedObject; }
      }

      public MozSmsEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MozSmsEvent()) {}

   }


}
