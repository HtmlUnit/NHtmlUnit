// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Speech
{
   public partial class WebkitSpeechRecognition : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static WebkitSpeechRecognition()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.speech.webkitSpeechRecognition o) =>
            new WebkitSpeechRecognition(o));
      }

      public WebkitSpeechRecognition(com.gargoylesoftware.htmlunit.javascript.host.speech.webkitSpeechRecognition wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.speech.webkitSpeechRecognition WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.speech.webkitSpeechRecognition)WrappedObject; }
      }

      public WebkitSpeechRecognition()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.speech.webkitSpeechRecognition()) {}

   }


}
