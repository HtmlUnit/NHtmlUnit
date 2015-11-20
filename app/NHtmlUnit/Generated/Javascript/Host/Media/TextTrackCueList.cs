// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class TextTrackCueList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static TextTrackCueList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.TextTrackCueList o) =>
            new TextTrackCueList(o));
      }

      public TextTrackCueList(com.gargoylesoftware.htmlunit.javascript.host.media.TextTrackCueList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.TextTrackCueList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.TextTrackCueList)WrappedObject; }
      }

      public TextTrackCueList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.TextTrackCueList()) {}

   }


}
