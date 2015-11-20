// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class WebKitAnimationEvent : NHtmlUnit.Javascript.Host.Events.AnimationEvent
   {
      static WebKitAnimationEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.WebKitAnimationEvent o) =>
            new WebKitAnimationEvent(o));
      }

      public WebKitAnimationEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.WebKitAnimationEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.WebKitAnimationEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.WebKitAnimationEvent)WrappedObject; }
      }

      public WebKitAnimationEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.WebKitAnimationEvent()) {}

   }


}
