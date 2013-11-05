// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLLIElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLLIElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLIElement o) =>
            new HTMLLIElement(o));
      }

      public HTMLLIElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLIElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLIElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLIElement)WrappedObject; }
      }

      public HTMLLIElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLIElement()) {}

   }


}
