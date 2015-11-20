// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class WebkitMediaStream : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static WebkitMediaStream()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.webkitMediaStream o) =>
            new WebkitMediaStream(o));
      }

      public WebkitMediaStream(com.gargoylesoftware.htmlunit.javascript.host.media.webkitMediaStream wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.webkitMediaStream WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.webkitMediaStream)WrappedObject; }
      }

      public WebkitMediaStream()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.webkitMediaStream()) {}

   }


}
