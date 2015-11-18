// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MIDIMessageEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static MIDIMessageEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MIDIMessageEvent o) =>
            new MIDIMessageEvent(o));
      }

      public MIDIMessageEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MIDIMessageEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MIDIMessageEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MIDIMessageEvent)WrappedObject; }
      }

      public MIDIMessageEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MIDIMessageEvent()) {}

   }


}
