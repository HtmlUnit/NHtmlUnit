// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class MediaSource : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static MediaSource()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.MediaSource o) =>
            new MediaSource(o));
      }

      public MediaSource(com.gargoylesoftware.htmlunit.javascript.host.media.MediaSource wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.MediaSource WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.MediaSource)WrappedObject; }
      }

      public MediaSource()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.MediaSource()) {}

   }


}
