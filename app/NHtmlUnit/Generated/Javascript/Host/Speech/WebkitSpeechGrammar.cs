// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Speech
{
   public partial class WebkitSpeechGrammar : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebkitSpeechGrammar()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.speech.webkitSpeechGrammar o) =>
            new WebkitSpeechGrammar(o));
      }

      public WebkitSpeechGrammar(com.gargoylesoftware.htmlunit.javascript.host.speech.webkitSpeechGrammar wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.speech.webkitSpeechGrammar WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.speech.webkitSpeechGrammar)WrappedObject; }
      }

      public WebkitSpeechGrammar()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.speech.webkitSpeechGrammar()) {}

   }


}
