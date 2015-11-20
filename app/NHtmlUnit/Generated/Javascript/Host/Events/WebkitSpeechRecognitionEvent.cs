// Generated class v2.19.0.0, don't modify

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
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.webkitSpeechRecognitionEvent o) =>
            new WebkitSpeechRecognitionEvent(o));
      }

      public WebkitSpeechRecognitionEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.webkitSpeechRecognitionEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.webkitSpeechRecognitionEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.webkitSpeechRecognitionEvent)WrappedObject; }
      }

      public WebkitSpeechRecognitionEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.webkitSpeechRecognitionEvent()) {}

   }


}
