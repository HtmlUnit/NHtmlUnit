// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLBaseElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLBaseElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBaseElement o) =>
            new HTMLBaseElement(o));
      }

      public HTMLBaseElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBaseElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBaseElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBaseElement)WrappedObject; }
      }

      public HTMLBaseElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBaseElement()) {}

// Generating method code for jsxGet_href
      public virtual string JsxGet_href()
      {
         return WObj.jsxGet_href();
      }

// Generating method code for jsxSet_href
      public virtual void JsxSet_href(string href)
      {
         WObj.jsxSet_href(href);
      }

// Generating method code for jsxGet_target
      public virtual string JsxGet_target()
      {
         return WObj.jsxGet_target();
      }

// Generating method code for jsxSet_target
      public virtual void JsxSet_target(string target)
      {
         WObj.jsxSet_target(target);
      }

   }


}
