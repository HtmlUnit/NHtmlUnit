// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Speech
{
   public partial class SpeechSynthesisErrorEvent : NHtmlUnit.Javascript.Host.Events.SpeechSynthesisEvent
   {
      static SpeechSynthesisErrorEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesisErrorEvent o) =>
            new SpeechSynthesisErrorEvent(o));
      }

      public SpeechSynthesisErrorEvent(com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesisErrorEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesisErrorEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesisErrorEvent)WrappedObject; }
      }

      public SpeechSynthesisErrorEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesisErrorEvent()) {}

   }


}
