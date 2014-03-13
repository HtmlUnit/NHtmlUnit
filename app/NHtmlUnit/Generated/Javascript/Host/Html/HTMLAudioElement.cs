// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLAudioElement : NHtmlUnit.Javascript.Host.Html.HTMLMediaElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLAudioElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAudioElement o) =>
            new HTMLAudioElement(o));
      }

      public HTMLAudioElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAudioElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAudioElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAudioElement)WrappedObject; }
      }

      public HTMLAudioElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAudioElement()) {}

   }


}
