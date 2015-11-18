// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class SecurityPolicyViolationEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static SecurityPolicyViolationEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.SecurityPolicyViolationEvent o) =>
            new SecurityPolicyViolationEvent(o));
      }

      public SecurityPolicyViolationEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.SecurityPolicyViolationEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.SecurityPolicyViolationEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.SecurityPolicyViolationEvent)WrappedObject; }
      }

      public SecurityPolicyViolationEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.SecurityPolicyViolationEvent()) {}

   }


}
