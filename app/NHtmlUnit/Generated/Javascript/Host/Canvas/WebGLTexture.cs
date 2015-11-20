// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class WebGLTexture : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebGLTexture()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLTexture o) =>
            new WebGLTexture(o));
      }

      public WebGLTexture(com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLTexture wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLTexture WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLTexture)WrappedObject; }
      }

      public WebGLTexture()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLTexture()) {}

   }


}
