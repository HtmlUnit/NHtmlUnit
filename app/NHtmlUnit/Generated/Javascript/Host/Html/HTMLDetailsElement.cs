// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDetailsElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLDetailsElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDetailsElement o) =>
            new HTMLDetailsElement(o));
      }

      public HTMLDetailsElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDetailsElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDetailsElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDetailsElement)WrappedObject; }
      }

      public HTMLDetailsElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDetailsElement()) {}

   }


}
