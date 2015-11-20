// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLShadowElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLShadowElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLShadowElement o) =>
            new HTMLShadowElement(o));
      }

      public HTMLShadowElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLShadowElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLShadowElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLShadowElement)WrappedObject; }
      }

      public HTMLShadowElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLShadowElement()) {}

   }


}
