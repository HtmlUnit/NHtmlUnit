// Generated class v2.50.0.0, don't modify

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
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.WebkitMediaStream o) =>
            new WebkitMediaStream(o));
      }

      public WebkitMediaStream(com.gargoylesoftware.htmlunit.javascript.host.media.WebkitMediaStream wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.WebkitMediaStream WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.WebkitMediaStream)WrappedObject; }
      }

      public WebkitMediaStream()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.WebkitMediaStream()) {}

   }


}
