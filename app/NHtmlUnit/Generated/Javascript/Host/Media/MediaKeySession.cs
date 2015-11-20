// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class MediaKeySession : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static MediaKeySession()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeySession o) =>
            new MediaKeySession(o));
      }

      public MediaKeySession(com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeySession wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeySession WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeySession)WrappedObject; }
      }

      public MediaKeySession()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeySession()) {}

   }


}
