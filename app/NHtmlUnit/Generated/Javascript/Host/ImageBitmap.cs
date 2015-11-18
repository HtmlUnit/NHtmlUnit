// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class ImageBitmap : NHtmlUnit.Javascript.SimpleScriptable
   {
      static ImageBitmap()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.ImageBitmap o) =>
            new ImageBitmap(o));
      }

      public ImageBitmap(com.gargoylesoftware.htmlunit.javascript.host.ImageBitmap wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.ImageBitmap WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.ImageBitmap)WrappedObject; }
      }

      public ImageBitmap()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.ImageBitmap()) {}

   }


}
