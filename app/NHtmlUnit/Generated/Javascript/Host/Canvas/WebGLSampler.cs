// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class WebGLSampler : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebGLSampler()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLSampler o) =>
            new WebGLSampler(o));
      }

      public WebGLSampler(com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLSampler wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLSampler WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLSampler)WrappedObject; }
      }

      public WebGLSampler()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLSampler()) {}

   }


}
