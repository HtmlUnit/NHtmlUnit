// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class WebGLContextEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static WebGLContextEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.WebGLContextEvent o) =>
            new WebGLContextEvent(o));
      }

      public WebGLContextEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.WebGLContextEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.WebGLContextEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.WebGLContextEvent)WrappedObject; }
      }

      public WebGLContextEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.WebGLContextEvent()) {}

   }


}
