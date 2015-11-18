// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class CompositionEvent : NHtmlUnit.Javascript.Host.Events.UIEvent
   {
      static CompositionEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.CompositionEvent o) =>
            new CompositionEvent(o));
      }

      public CompositionEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.CompositionEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.CompositionEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.CompositionEvent)WrappedObject; }
      }

      public CompositionEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.CompositionEvent()) {}

   }


}
