// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class WebGLActiveInfo : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebGLActiveInfo()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLActiveInfo o) =>
            new WebGLActiveInfo(o));
      }

      public WebGLActiveInfo(com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLActiveInfo wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLActiveInfo WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLActiveInfo)WrappedObject; }
      }

      public WebGLActiveInfo()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLActiveInfo()) {}

   }


}
