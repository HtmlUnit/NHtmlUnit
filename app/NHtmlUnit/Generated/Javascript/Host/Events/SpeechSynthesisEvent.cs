// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class SpeechSynthesisEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static SpeechSynthesisEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.SpeechSynthesisEvent o) =>
            new SpeechSynthesisEvent(o));
      }

      public SpeechSynthesisEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.SpeechSynthesisEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.SpeechSynthesisEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.SpeechSynthesisEvent)WrappedObject; }
      }

      public SpeechSynthesisEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.SpeechSynthesisEvent()) {}

   }


}
