// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Midi
{
   public partial class MIDIAccess : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static MIDIAccess()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIAccess o) =>
            new MIDIAccess(o));
      }

      public MIDIAccess(com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIAccess wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIAccess WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIAccess)WrappedObject; }
      }

      public MIDIAccess()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIAccess()) {}

   }


}
