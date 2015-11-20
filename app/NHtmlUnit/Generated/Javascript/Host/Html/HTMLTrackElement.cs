// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTrackElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLTrackElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTrackElement o) =>
            new HTMLTrackElement(o));
      }

      public HTMLTrackElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTrackElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTrackElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTrackElement)WrappedObject; }
      }

      public HTMLTrackElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTrackElement()) {}

   }


}
