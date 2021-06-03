// Generated class v2.50.0.0, don't modify

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
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.speech.WebkitSpeechGrammar o) =>
            new WebkitSpeechGrammar(o));
      }

      public WebkitSpeechGrammar(com.gargoylesoftware.htmlunit.javascript.host.speech.WebkitSpeechGrammar wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.speech.WebkitSpeechGrammar WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.speech.WebkitSpeechGrammar)WrappedObject; }
      }

      public WebkitSpeechGrammar()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.speech.WebkitSpeechGrammar()) {}

   }


}
