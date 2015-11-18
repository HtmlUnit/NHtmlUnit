// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class MediaRecorder : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static MediaRecorder()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.MediaRecorder o) =>
            new MediaRecorder(o));
      }

      public MediaRecorder(com.gargoylesoftware.htmlunit.javascript.host.media.MediaRecorder wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.MediaRecorder WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.MediaRecorder)WrappedObject; }
      }

      public MediaRecorder()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.MediaRecorder()) {}

   }


}
