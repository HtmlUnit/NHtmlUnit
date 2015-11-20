// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class InputEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static InputEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.InputEvent o) =>
            new InputEvent(o));
      }

      public InputEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.InputEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.InputEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.InputEvent)WrappedObject; }
      }

      public InputEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.InputEvent()) {}

   }


}
