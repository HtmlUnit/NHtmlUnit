// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Midi
{
   public partial class MIDIOutputMap : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MIDIOutputMap()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIOutputMap o) =>
            new MIDIOutputMap(o));
      }

      public MIDIOutputMap(com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIOutputMap wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIOutputMap WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIOutputMap)WrappedObject; }
      }

      public MIDIOutputMap()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIOutputMap()) {}

   }


}
