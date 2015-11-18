// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class WebkitSpeechRecognitionError : NHtmlUnit.Javascript.Host.Events.Event
   {
      static WebkitSpeechRecognitionError()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.webkitSpeechRecognitionError o) =>
            new WebkitSpeechRecognitionError(o));
      }

      public WebkitSpeechRecognitionError(com.gargoylesoftware.htmlunit.javascript.host.@event.webkitSpeechRecognitionError wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.webkitSpeechRecognitionError WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.webkitSpeechRecognitionError)WrappedObject; }
      }

      public WebkitSpeechRecognitionError()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.webkitSpeechRecognitionError()) {}

   }


}
