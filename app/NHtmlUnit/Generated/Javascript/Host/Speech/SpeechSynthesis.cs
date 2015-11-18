// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Speech
{
   public partial class SpeechSynthesis : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static SpeechSynthesis()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesis o) =>
            new SpeechSynthesis(o));
      }

      public SpeechSynthesis(com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesis wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesis WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesis)WrappedObject; }
      }

      public SpeechSynthesis()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesis()) {}

   }


}
