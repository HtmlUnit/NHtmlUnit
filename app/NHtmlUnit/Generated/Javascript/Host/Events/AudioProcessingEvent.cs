// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class AudioProcessingEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static AudioProcessingEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.AudioProcessingEvent o) =>
            new AudioProcessingEvent(o));
      }

      public AudioProcessingEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.AudioProcessingEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.AudioProcessingEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.AudioProcessingEvent)WrappedObject; }
      }

      public AudioProcessingEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.AudioProcessingEvent()) {}

   }


}
