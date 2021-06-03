// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Speech
{
   public partial class SpeechSynthesisVoice : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SpeechSynthesisVoice()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesisVoice o) =>
            new SpeechSynthesisVoice(o));
      }

      public SpeechSynthesisVoice(com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesisVoice wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesisVoice WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesisVoice)WrappedObject; }
      }

      public SpeechSynthesisVoice()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesisVoice()) {}

   }


}
