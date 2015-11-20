// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class WebGLFramebuffer : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebGLFramebuffer()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLFramebuffer o) =>
            new WebGLFramebuffer(o));
      }

      public WebGLFramebuffer(com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLFramebuffer wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLFramebuffer WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLFramebuffer)WrappedObject; }
      }

      public WebGLFramebuffer()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLFramebuffer()) {}

   }


}
