// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLUListElement : NHtmlUnit.Javascript.Host.Html.HTMLListElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLUListElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLUListElement o) =>
            new HTMLUListElement(o));
      }

      public HTMLUListElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLUListElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLUListElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLUListElement)WrappedObject; }
      }

      public HTMLUListElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLUListElement()) {}

   }


}
