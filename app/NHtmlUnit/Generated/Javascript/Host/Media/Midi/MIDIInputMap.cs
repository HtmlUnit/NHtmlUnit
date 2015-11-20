// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Midi
{
   public partial class MIDIInputMap : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MIDIInputMap()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIInputMap o) =>
            new MIDIInputMap(o));
      }

      public MIDIInputMap(com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIInputMap wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIInputMap WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIInputMap)WrappedObject; }
      }

      public MIDIInputMap()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIInputMap()) {}

   }


}
