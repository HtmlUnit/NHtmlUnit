// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class WebGLQuery : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebGLQuery()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLQuery o) =>
            new WebGLQuery(o));
      }

      public WebGLQuery(com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLQuery wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLQuery WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLQuery)WrappedObject; }
      }

      public WebGLQuery()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLQuery()) {}

   }


}
