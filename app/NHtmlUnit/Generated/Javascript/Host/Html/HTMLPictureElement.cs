// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLPictureElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLPictureElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPictureElement o) =>
            new HTMLPictureElement(o));
      }

      public HTMLPictureElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPictureElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPictureElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPictureElement)WrappedObject; }
      }

      public HTMLPictureElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPictureElement()) {}

   }


}
