// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class UserProximityEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static UserProximityEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.UserProximityEvent o) =>
            new UserProximityEvent(o));
      }

      public UserProximityEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.UserProximityEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.UserProximityEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.UserProximityEvent)WrappedObject; }
      }

      public UserProximityEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.UserProximityEvent()) {}

   }


}
