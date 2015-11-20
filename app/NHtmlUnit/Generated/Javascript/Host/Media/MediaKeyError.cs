// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class MediaKeyError : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MediaKeyError()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeyError o) =>
            new MediaKeyError(o));
      }

      public MediaKeyError(com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeyError wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeyError WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeyError)WrappedObject; }
      }

      public MediaKeyError()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeyError()) {}

   }


}
