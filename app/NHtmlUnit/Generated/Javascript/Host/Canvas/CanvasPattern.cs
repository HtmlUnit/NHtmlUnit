// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class CanvasPattern : NHtmlUnit.Javascript.SimpleScriptable
   {
      static CanvasPattern()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasPattern o) =>
            new CanvasPattern(o));
      }

      public CanvasPattern(com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasPattern wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasPattern WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasPattern)WrappedObject; }
      }

      public CanvasPattern()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasPattern()) {}

   }


}
