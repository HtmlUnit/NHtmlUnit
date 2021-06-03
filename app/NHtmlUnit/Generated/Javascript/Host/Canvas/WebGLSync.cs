// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class WebGLSync : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebGLSync()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLSync o) =>
            new WebGLSync(o));
      }

      public WebGLSync(com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLSync wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLSync WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLSync)WrappedObject; }
      }

      public WebGLSync()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLSync()) {}

   }


}
