// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class PageTransitionEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static PageTransitionEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.PageTransitionEvent o) =>
            new PageTransitionEvent(o));
      }

      public PageTransitionEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.PageTransitionEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.PageTransitionEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.PageTransitionEvent)WrappedObject; }
      }

      public PageTransitionEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.PageTransitionEvent()) {}

   }


}
