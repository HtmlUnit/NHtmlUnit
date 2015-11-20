// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class Image : NHtmlUnit.Javascript.Host.Html.HTMLImageElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static Image()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.Image o) =>
            new Image(o));
      }

      public Image(com.gargoylesoftware.htmlunit.javascript.host.html.Image wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.Image WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.Image)WrappedObject; }
      }

      public Image()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.Image()) {}

   }


}
