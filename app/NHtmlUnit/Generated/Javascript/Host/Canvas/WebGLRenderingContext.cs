// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class WebGLRenderingContext : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebGLRenderingContext()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLRenderingContext o) =>
            new WebGLRenderingContext(o));
      }

      public WebGLRenderingContext(com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLRenderingContext wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLRenderingContext WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLRenderingContext)WrappedObject; }
      }

      public WebGLRenderingContext()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLRenderingContext()) {}

   }


}
