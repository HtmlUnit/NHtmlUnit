// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Midi
{
   public partial class MIDIInput : NHtmlUnit.Javascript.Host.Media.Midi.MIDIPort
   {
      static MIDIInput()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIInput o) =>
            new MIDIInput(o));
      }

      public MIDIInput(com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIInput wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIInput WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIInput)WrappedObject; }
      }

      public MIDIInput()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIInput()) {}

   }


}
