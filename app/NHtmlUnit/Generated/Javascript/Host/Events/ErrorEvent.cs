// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class ErrorEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static ErrorEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.ErrorEvent o) =>
            new ErrorEvent(o));
      }

      public ErrorEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.ErrorEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.ErrorEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.ErrorEvent)WrappedObject; }
      }

      public ErrorEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.ErrorEvent()) {}

   }


}
