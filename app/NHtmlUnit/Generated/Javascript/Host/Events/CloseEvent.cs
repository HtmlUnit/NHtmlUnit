// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class CloseEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static CloseEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.CloseEvent o) =>
            new CloseEvent(o));
      }

      public CloseEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.CloseEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.CloseEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.CloseEvent)WrappedObject; }
      }

      public CloseEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.CloseEvent()) {}

   }


}
