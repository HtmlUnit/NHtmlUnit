// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class EventSource : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static EventSource()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.EventSource o) =>
            new EventSource(o));
      }

      public EventSource(com.gargoylesoftware.htmlunit.javascript.host.@event.EventSource wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.EventSource WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.EventSource)WrappedObject; }
      }

      public EventSource()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.EventSource()) {}

   }


}
