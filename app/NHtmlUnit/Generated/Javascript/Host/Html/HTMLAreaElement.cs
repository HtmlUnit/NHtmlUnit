// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLAreaElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLAreaElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAreaElement o) =>
            new HTMLAreaElement(o));
      }

      public HTMLAreaElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAreaElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAreaElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAreaElement)WrappedObject; }
      }

      public HTMLAreaElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAreaElement()) {}

// Generating method code for jsxGet_alt
      public virtual string JsxGet_alt()
      {
         return WObj.jsxGet_alt();
      }

// Generating method code for jsxSet_alt
      public virtual void JsxSet_alt(string alt)
      {
         WObj.jsxSet_alt(alt);
      }

   }


}
