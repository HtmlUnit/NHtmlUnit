// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class CanvasGradient : NHtmlUnit.Javascript.SimpleScriptable
   {
      static CanvasGradient()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasGradient o) =>
            new CanvasGradient(o));
      }

      public CanvasGradient(com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasGradient wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasGradient WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasGradient)WrappedObject; }
      }

      public CanvasGradient()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasGradient()) {}

   }


}
