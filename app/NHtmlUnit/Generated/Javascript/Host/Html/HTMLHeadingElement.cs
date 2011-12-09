// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLHeadingElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLHeadingElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHeadingElement o) =>
            new HTMLHeadingElement(o));
      }

      public HTMLHeadingElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHeadingElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHeadingElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHeadingElement)WrappedObject; }
      }

      public HTMLHeadingElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHeadingElement()) {}

   }


}
