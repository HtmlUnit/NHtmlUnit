// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLBRElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLBRElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBRElement o) =>
            new HTMLBRElement(o));
      }

      public HTMLBRElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBRElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBRElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBRElement)WrappedObject; }
      }

      public HTMLBRElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBRElement()) {}

// Generating method code for jsxGet_clear
      public virtual string JsxGet_clear()
      {
         return WObj.jsxGet_clear();
      }

// Generating method code for jsxSet_clear
      public virtual void JsxSet_clear(string clear)
      {
         WObj.jsxSet_clear(clear);
      }

   }


}
