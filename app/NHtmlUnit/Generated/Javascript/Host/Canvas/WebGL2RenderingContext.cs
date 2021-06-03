// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class WebGL2RenderingContext : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WebGL2RenderingContext()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGL2RenderingContext o) =>
            new WebGL2RenderingContext(o));
      }

      public WebGL2RenderingContext(com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGL2RenderingContext wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGL2RenderingContext WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGL2RenderingContext)WrappedObject; }
      }

      public WebGL2RenderingContext()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.WebGL2RenderingContext()) {}

   }


}
