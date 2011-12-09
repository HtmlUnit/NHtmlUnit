// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTitleElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLTitleElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTitleElement o) =>
            new HTMLTitleElement(o));
      }

      public HTMLTitleElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTitleElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTitleElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTitleElement)WrappedObject; }
      }

      public HTMLTitleElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTitleElement()) {}

// Generating method code for jsxSet_text
      public virtual void JsxSet_text(string text)
      {
         WObj.jsxSet_text(text);
      }

   }


}
