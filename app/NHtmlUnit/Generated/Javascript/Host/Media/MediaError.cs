// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class MediaError : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MediaError()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.MediaError o) =>
            new MediaError(o));
      }

      public MediaError(com.gargoylesoftware.htmlunit.javascript.host.media.MediaError wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.MediaError WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.MediaError)WrappedObject; }
      }

      public MediaError()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.MediaError()) {}

   }


}
