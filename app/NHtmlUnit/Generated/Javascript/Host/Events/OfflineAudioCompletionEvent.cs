// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class OfflineAudioCompletionEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static OfflineAudioCompletionEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.OfflineAudioCompletionEvent o) =>
            new OfflineAudioCompletionEvent(o));
      }

      public OfflineAudioCompletionEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.OfflineAudioCompletionEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.OfflineAudioCompletionEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.OfflineAudioCompletionEvent)WrappedObject; }
      }

      public OfflineAudioCompletionEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.OfflineAudioCompletionEvent()) {}

   }


}
