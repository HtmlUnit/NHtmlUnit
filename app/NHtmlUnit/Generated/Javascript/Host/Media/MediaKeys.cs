// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class MediaKeys : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MediaKeys()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeys o) =>
            new MediaKeys(o));
      }

      public MediaKeys(com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeys wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeys WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeys)WrappedObject; }
      }

      public MediaKeys()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeys()) {}

   }


}
