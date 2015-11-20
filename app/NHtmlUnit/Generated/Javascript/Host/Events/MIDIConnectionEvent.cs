// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MIDIConnectionEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static MIDIConnectionEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MIDIConnectionEvent o) =>
            new MIDIConnectionEvent(o));
      }

      public MIDIConnectionEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MIDIConnectionEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MIDIConnectionEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MIDIConnectionEvent)WrappedObject; }
      }

      public MIDIConnectionEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MIDIConnectionEvent()) {}

   }


}
