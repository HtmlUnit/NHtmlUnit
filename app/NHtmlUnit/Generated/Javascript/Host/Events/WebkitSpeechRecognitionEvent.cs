// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class WebkitSpeechRecognitionEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static WebkitSpeechRecognitionEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.WebkitSpeechRecognitionEvent o) =>
            new WebkitSpeechRecognitionEvent(o));
      }

      public WebkitSpeechRecognitionEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.WebkitSpeechRecognitionEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.WebkitSpeechRecognitionEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.WebkitSpeechRecognitionEvent)WrappedObject; }
      }

      public WebkitSpeechRecognitionEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.WebkitSpeechRecognitionEvent()) {}

   }


}
