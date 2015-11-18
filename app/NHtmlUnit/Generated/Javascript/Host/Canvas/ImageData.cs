// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class ImageData : NHtmlUnit.Javascript.SimpleScriptable
   {
      static ImageData()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.ImageData o) =>
            new ImageData(o));
      }

      public ImageData(com.gargoylesoftware.htmlunit.javascript.host.canvas.ImageData wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.ImageData WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.ImageData)WrappedObject; }
      }

      public ImageData()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.ImageData()) {}


      public System.Int32 Width
      {
         get
         {
            return WObj.getWidth();
         }
      }

      public System.Int32 Height
      {
         get
         {
            return WObj.getHeight();
         }
      }

      public NHtmlUnit.Javascript.Host.Arrays.Uint8ClampedArray Data
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Arrays.Uint8ClampedArray>(
               WObj.getData());
         }
      }

   }


}
