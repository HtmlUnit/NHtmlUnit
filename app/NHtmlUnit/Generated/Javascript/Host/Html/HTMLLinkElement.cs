// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLLinkElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLLinkElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLinkElement o) =>
            new HTMLLinkElement(o));
      }

      public HTMLLinkElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLinkElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLinkElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLinkElement)WrappedObject; }
      }

      public HTMLLinkElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLinkElement()) {}


      public NHtmlUnit.Javascript.Host.Css.CSSStyleSheet Sheet
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleSheet>(
               WObj.getSheet());
         }
      }

// Generating method code for jsxSet_href
      public virtual void JsxSet_href(string href)
      {
         WObj.jsxSet_href(href);
      }

// Generating method code for jsxGet_href
      public virtual string JsxGet_href()
      {
         return WObj.jsxGet_href();
      }

// Generating method code for jsxSet_rel
      public virtual void JsxSet_rel(string rel)
      {
         WObj.jsxSet_rel(rel);
      }

// Generating method code for jsxGet_rel
      public virtual string JsxGet_rel()
      {
         return WObj.jsxGet_rel();
      }

// Generating method code for jsxSet_rev
      public virtual void JsxSet_rev(string rel)
      {
         WObj.jsxSet_rev(rel);
      }

// Generating method code for jsxGet_rev
      public virtual string JsxGet_rev()
      {
         return WObj.jsxGet_rev();
      }

// Generating method code for jsxSet_type
      public virtual void JsxSet_type(string type)
      {
         WObj.jsxSet_type(type);
      }

// Generating method code for jsxGet_type
      public virtual string JsxGet_type()
      {
         return WObj.jsxGet_type();
      }

   }


}
