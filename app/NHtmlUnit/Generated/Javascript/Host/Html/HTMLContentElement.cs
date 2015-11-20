// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLContentElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLContentElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLContentElement o) =>
            new HTMLContentElement(o));
      }

      public HTMLContentElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLContentElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLContentElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLContentElement)WrappedObject; }
      }

      public HTMLContentElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLContentElement()) {}

   }


}
