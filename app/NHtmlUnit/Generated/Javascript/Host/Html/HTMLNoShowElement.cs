// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLNoShowElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLNoShowElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLNoShowElement o) =>
            new HTMLNoShowElement(o));
      }

      public HTMLNoShowElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLNoShowElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLNoShowElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLNoShowElement)WrappedObject; }
      }

      public HTMLNoShowElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLNoShowElement()) {}

   }


}
