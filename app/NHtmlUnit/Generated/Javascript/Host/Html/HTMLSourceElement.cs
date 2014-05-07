// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLSourceElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLSourceElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSourceElement o) =>
            new HTMLSourceElement(o));
      }

      public HTMLSourceElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSourceElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSourceElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSourceElement)WrappedObject; }
      }

      public HTMLSourceElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSourceElement()) {}

   }


}
