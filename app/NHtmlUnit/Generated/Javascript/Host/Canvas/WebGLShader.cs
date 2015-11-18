// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class WebGLShader : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebGLShader()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLShader o) =>
            new WebGLShader(o));
      }

      public WebGLShader(com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLShader wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLShader WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLShader)WrappedObject; }
      }

      public WebGLShader()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLShader()) {}

   }


}
