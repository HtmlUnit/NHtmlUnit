// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class WebGLVertexArrayObject : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebGLVertexArrayObject()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLVertexArrayObject o) =>
            new WebGLVertexArrayObject(o));
      }

      public WebGLVertexArrayObject(com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLVertexArrayObject wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLVertexArrayObject WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLVertexArrayObject)WrappedObject; }
      }

      public WebGLVertexArrayObject()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLVertexArrayObject()) {}

   }


}
