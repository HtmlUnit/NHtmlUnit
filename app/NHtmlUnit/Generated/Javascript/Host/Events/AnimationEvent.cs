// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class AnimationEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static AnimationEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.AnimationEvent o) =>
            new AnimationEvent(o));
      }

      public AnimationEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.AnimationEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.AnimationEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.AnimationEvent)WrappedObject; }
      }

      public AnimationEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.AnimationEvent()) {}

   }


}
