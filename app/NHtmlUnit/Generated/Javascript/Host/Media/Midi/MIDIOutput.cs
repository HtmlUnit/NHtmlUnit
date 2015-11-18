// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Midi
{
   public partial class MIDIOutput : NHtmlUnit.Javascript.Host.Media.Midi.MIDIPort
   {
      static MIDIOutput()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIOutput o) =>
            new MIDIOutput(o));
      }

      public MIDIOutput(com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIOutput wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIOutput WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIOutput)WrappedObject; }
      }

      public MIDIOutput()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.midi.MIDIOutput()) {}

   }


}
