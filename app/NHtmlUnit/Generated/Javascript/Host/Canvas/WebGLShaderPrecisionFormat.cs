// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class WebGLShaderPrecisionFormat : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebGLShaderPrecisionFormat()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLShaderPrecisionFormat o) =>
            new WebGLShaderPrecisionFormat(o));
      }

      public WebGLShaderPrecisionFormat(com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLShaderPrecisionFormat wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLShaderPrecisionFormat WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLShaderPrecisionFormat)WrappedObject; }
      }

      public WebGLShaderPrecisionFormat()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLShaderPrecisionFormat()) {}

   }


}
