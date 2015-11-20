// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class WebGLProgram : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebGLProgram()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLProgram o) =>
            new WebGLProgram(o));
      }

      public WebGLProgram(com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLProgram wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLProgram WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLProgram)WrappedObject; }
      }

      public WebGLProgram()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLProgram()) {}

   }


}
