// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class TextTrack : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static TextTrack()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.TextTrack o) =>
            new TextTrack(o));
      }

      public TextTrack(com.gargoylesoftware.htmlunit.javascript.host.media.TextTrack wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.TextTrack WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.TextTrack)WrappedObject; }
      }

      public TextTrack()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.TextTrack()) {}

   }


}
