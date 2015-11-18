// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class WebGLRenderbuffer : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebGLRenderbuffer()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLRenderbuffer o) =>
            new WebGLRenderbuffer(o));
      }

      public WebGLRenderbuffer(com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLRenderbuffer wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLRenderbuffer WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLRenderbuffer)WrappedObject; }
      }

      public WebGLRenderbuffer()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLRenderbuffer()) {}

   }


}
