// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLOutputElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLOutputElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOutputElement o) =>
            new HTMLOutputElement(o));
      }

      public HTMLOutputElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOutputElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOutputElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOutputElement)WrappedObject; }
      }

      public HTMLOutputElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOutputElement()) {}

   }


}
