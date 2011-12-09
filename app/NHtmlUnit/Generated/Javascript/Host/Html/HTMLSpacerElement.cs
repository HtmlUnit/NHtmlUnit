// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLSpacerElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLSpacerElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSpacerElement o) =>
            new HTMLSpacerElement(o));
      }

      public HTMLSpacerElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSpacerElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSpacerElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSpacerElement)WrappedObject; }
      }

      public HTMLSpacerElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSpacerElement()) {}

   }


}
