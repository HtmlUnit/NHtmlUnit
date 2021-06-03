// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MSGestureEvent : NHtmlUnit.Javascript.Host.Events.UIEvent
   {
      static MSGestureEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MSGestureEvent o) =>
            new MSGestureEvent(o));
      }

      public MSGestureEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MSGestureEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MSGestureEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MSGestureEvent)WrappedObject; }
      }

      public MSGestureEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MSGestureEvent()) {}

   }


}
