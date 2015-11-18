// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class WebKitTransitionEvent : NHtmlUnit.Javascript.Host.Events.TransitionEvent
   {
      static WebKitTransitionEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.WebKitTransitionEvent o) =>
            new WebKitTransitionEvent(o));
      }

      public WebKitTransitionEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.WebKitTransitionEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.WebKitTransitionEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.WebKitTransitionEvent)WrappedObject; }
      }

      public WebKitTransitionEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.WebKitTransitionEvent()) {}

   }


}
