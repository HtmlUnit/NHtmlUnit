// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class MediaKeySystemAccess : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MediaKeySystemAccess()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeySystemAccess o) =>
            new MediaKeySystemAccess(o));
      }

      public MediaKeySystemAccess(com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeySystemAccess wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeySystemAccess WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeySystemAccess)WrappedObject; }
      }

      public MediaKeySystemAccess()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeySystemAccess()) {}

   }


}
