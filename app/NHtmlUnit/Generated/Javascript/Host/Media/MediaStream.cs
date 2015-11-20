// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class MediaStream : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MediaStream()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.MediaStream o) =>
            new MediaStream(o));
      }

      public MediaStream(com.gargoylesoftware.htmlunit.javascript.host.media.MediaStream wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.MediaStream WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.MediaStream)WrappedObject; }
      }

      public MediaStream()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.MediaStream()) {}

   }


}
