// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLUnknownElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLUnknownElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLUnknownElement o) =>
            new HTMLUnknownElement(o));
      }

      public HTMLUnknownElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLUnknownElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLUnknownElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLUnknownElement)WrappedObject; }
      }

      public HTMLUnknownElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLUnknownElement()) {}

   }


}
