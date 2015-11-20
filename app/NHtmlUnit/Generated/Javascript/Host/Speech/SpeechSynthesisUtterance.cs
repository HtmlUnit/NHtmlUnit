// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Speech
{
   public partial class SpeechSynthesisUtterance : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static SpeechSynthesisUtterance()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesisUtterance o) =>
            new SpeechSynthesisUtterance(o));
      }

      public SpeechSynthesisUtterance(com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesisUtterance wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesisUtterance WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesisUtterance)WrappedObject; }
      }

      public SpeechSynthesisUtterance()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.speech.SpeechSynthesisUtterance()) {}

   }


}
