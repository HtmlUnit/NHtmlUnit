// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class TextTrackList : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static TextTrackList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.TextTrackList o) =>
            new TextTrackList(o));
      }

      public TextTrackList(com.gargoylesoftware.htmlunit.javascript.host.media.TextTrackList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.TextTrackList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.TextTrackList)WrappedObject; }
      }

      public TextTrackList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.TextTrackList()) {}

   }


}
