// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class WebGLUniformLocation : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebGLUniformLocation()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLUniformLocation o) =>
            new WebGLUniformLocation(o));
      }

      public WebGLUniformLocation(com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLUniformLocation wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLUniformLocation WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLUniformLocation)WrappedObject; }
      }

      public WebGLUniformLocation()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLUniformLocation()) {}

   }


}
