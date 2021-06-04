// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class WebGLTransformFeedback : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebGLTransformFeedback()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLTransformFeedback o) =>
            new WebGLTransformFeedback(o));
      }

      public WebGLTransformFeedback(com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLTransformFeedback wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLTransformFeedback WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLTransformFeedback)WrappedObject; }
      }

      public WebGLTransformFeedback()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGLTransformFeedback()) {}

   }


}
