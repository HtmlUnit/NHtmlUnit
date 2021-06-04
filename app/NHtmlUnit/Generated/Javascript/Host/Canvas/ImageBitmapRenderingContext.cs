// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class ImageBitmapRenderingContext : NHtmlUnit.Javascript.SimpleScriptable
   {
      static ImageBitmapRenderingContext()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.ImageBitmapRenderingContext o) =>
            new ImageBitmapRenderingContext(o));
      }

      public ImageBitmapRenderingContext(com.gargoylesoftware.htmlunit.javascript.host.canvas.ImageBitmapRenderingContext wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.ImageBitmapRenderingContext WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.ImageBitmapRenderingContext)WrappedObject; }
      }

      public ImageBitmapRenderingContext()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.ImageBitmapRenderingContext()) {}

   }


}
