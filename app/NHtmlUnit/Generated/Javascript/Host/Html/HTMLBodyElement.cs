// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLBodyElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLBodyElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBodyElement o) =>
            new HTMLBodyElement(o));
      }

      public HTMLBodyElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBodyElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBodyElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBodyElement)WrappedObject; }
      }

      public HTMLBodyElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBodyElement()) {}

// Generating method code for createEventHandlerFromAttribute
      public virtual void CreateEventHandlerFromAttribute(string attributeName, string value)
      {
         WObj.createEventHandlerFromAttribute(attributeName, value);
      }

// Generating method code for jsxGet_aLink
      public virtual string JsxGet_aLink()
      {
         return WObj.jsxGet_aLink();
      }

// Generating method code for jsxSet_aLink
      public virtual void JsxSet_aLink(string aLink)
      {
         WObj.jsxSet_aLink(aLink);
      }

// Generating method code for jsxGet_background
      public virtual string JsxGet_background()
      {
         return WObj.jsxGet_background();
      }

// Generating method code for jsxSet_background
      public virtual void JsxSet_background(string background)
      {
         WObj.jsxSet_background(background);
      }

// Generating method code for jsxGet_bgColor
      public virtual string JsxGet_bgColor()
      {
         return WObj.jsxGet_bgColor();
      }

// Generating method code for jsxSet_bgColor
      public virtual void JsxSet_bgColor(string bgColor)
      {
         WObj.jsxSet_bgColor(bgColor);
      }

// Generating method code for jsxGet_link
      public virtual string JsxGet_link()
      {
         return WObj.jsxGet_link();
      }

// Generating method code for jsxSet_link
      public virtual void JsxSet_link(string link)
      {
         WObj.jsxSet_link(link);
      }

// Generating method code for jsxSet_text
      public virtual void JsxSet_text(string text)
      {
         WObj.jsxSet_text(text);
      }

// Generating method code for jsxGet_vLink
      public virtual string JsxGet_vLink()
      {
         return WObj.jsxGet_vLink();
      }

// Generating method code for jsxSet_vLink
      public virtual void JsxSet_vLink(string vLink)
      {
         WObj.jsxSet_vLink(vLink);
      }

   }


}
