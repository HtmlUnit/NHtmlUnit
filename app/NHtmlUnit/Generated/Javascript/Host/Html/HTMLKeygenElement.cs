// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLKeygenElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLKeygenElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLKeygenElement o) =>
            new HTMLKeygenElement(o));
      }

      public HTMLKeygenElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLKeygenElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLKeygenElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLKeygenElement)WrappedObject; }
      }

      public HTMLKeygenElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLKeygenElement()) {}

   }


}
