// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class WebGLBuffer : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebGLBuffer()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLBuffer o) =>
            new WebGLBuffer(o));
      }

      public WebGLBuffer(com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLBuffer wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLBuffer WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLBuffer)WrappedObject; }
      }

      public WebGLBuffer()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLBuffer()) {}

   }


}
