// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Midi
{
   public partial class MIDIPort : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static MIDIPort()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIPort o) =>
            new MIDIPort(o));
      }

      public MIDIPort(com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIPort wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIPort WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIPort)WrappedObject; }
      }

      public MIDIPort()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIPort()) {}

   }


}
