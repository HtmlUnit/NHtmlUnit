// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class GamepadEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static GamepadEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.GamepadEvent o) =>
            new GamepadEvent(o));
      }

      public GamepadEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.GamepadEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.GamepadEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.GamepadEvent)WrappedObject; }
      }

      public GamepadEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.GamepadEvent()) {}

   }


}
