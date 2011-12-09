// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLMetaElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLMetaElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMetaElement o) =>
            new HTMLMetaElement(o));
      }

      public HTMLMetaElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMetaElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMetaElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMetaElement)WrappedObject; }
      }

      public HTMLMetaElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMetaElement()) {}

// Generating method code for jsxGet_charset
      public virtual string JsxGet_charset()
      {
         return WObj.jsxGet_charset();
      }

// Generating method code for jsxSet_charset
      public virtual void JsxSet_charset(string charset)
      {
         WObj.jsxSet_charset(charset);
      }

// Generating method code for jsxGet_content
      public virtual string JsxGet_content()
      {
         return WObj.jsxGet_content();
      }

// Generating method code for jsxSet_content
      public virtual void JsxSet_content(string content)
      {
         WObj.jsxSet_content(content);
      }

// Generating method code for jsxGet_httpEquiv
      public virtual string JsxGet_httpEquiv()
      {
         return WObj.jsxGet_httpEquiv();
      }

// Generating method code for jsxSet_httpEquiv
      public virtual void JsxSet_httpEquiv(string httpEquiv)
      {
         WObj.jsxSet_httpEquiv(httpEquiv);
      }

// Generating method code for jsxGet_name
      public virtual string JsxGet_name()
      {
         return WObj.jsxGet_name();
      }

// Generating method code for jsxSet_name
      public virtual void JsxSet_name(string name)
      {
         WObj.jsxSet_name(name);
      }

// Generating method code for jsxGet_scheme
      public virtual string JsxGet_scheme()
      {
         return WObj.jsxGet_scheme();
      }

// Generating method code for jsxSet_scheme
      public virtual void JsxSet_scheme(string scheme)
      {
         WObj.jsxSet_scheme(scheme);
      }

// Generating method code for jsxGet_url
      public virtual string JsxGet_url()
      {
         return WObj.jsxGet_url();
      }

// Generating method code for jsxSet_url
      public virtual void JsxSet_url(string url)
      {
         WObj.jsxSet_url(url);
      }

   }


}
