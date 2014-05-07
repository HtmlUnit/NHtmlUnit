// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLVideoElement : NHtmlUnit.Javascript.Host.Html.HTMLMediaElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLVideoElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLVideoElement o) =>
            new HTMLVideoElement(o));
      }

      public HTMLVideoElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLVideoElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLVideoElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLVideoElement)WrappedObject; }
      }

      public HTMLVideoElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLVideoElement()) {}

   }


}
