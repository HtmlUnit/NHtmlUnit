// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLImageElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLImageElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLImageElement o) =>
            new HTMLImageElement(o));
      }

      public HTMLImageElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLImageElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLImageElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLImageElement)WrappedObject; }
      }

      public HTMLImageElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLImageElement()) {}

// Generating method code for jsConstructor
      public virtual void JsConstructor()
      {
         WObj.jsConstructor();
      }

// Generating method code for jsxSet_src
      public virtual void JsxSet_src(string src)
      {
         WObj.jsxSet_src(src);
      }

// Generating method code for jsxGet_src
      public virtual string JsxGet_src()
      {
         return WObj.jsxGet_src();
      }

// Generating method code for jsxSet_onload
      public virtual void JsxSet_onload(object onloadHandler)
      {
         WObj.jsxSet_onload(onloadHandler);
      }

// Generating method code for jsxGet_onload
      public virtual object JsxGet_onload()
      {
         return WObj.jsxGet_onload();
      }

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

// Generating method code for jsxGet_border
      public virtual string JsxGet_border()
      {
         return WObj.jsxGet_border();
      }

// Generating method code for jsxSet_border
      public virtual void JsxSet_border(string border)
      {
         WObj.jsxSet_border(border);
      }

// Generating method code for jsxGet_align
      public virtual string JsxGet_align()
      {
         return WObj.jsxGet_align();
      }

// Generating method code for jsxSet_align
      public virtual void JsxSet_align(string align)
      {
         WObj.jsxSet_align(align);
      }

// Generating method code for jsxGet_width
      public virtual int JsxGet_width()
      {
         return WObj.jsxGet_width();
      }

// Generating method code for jsxSet_width
      public virtual void JsxSet_width(string width)
      {
         WObj.jsxSet_width(width);
      }

// Generating method code for jsxGet_height
      public virtual int JsxGet_height()
      {
         return WObj.jsxGet_height();
      }

// Generating method code for jsxSet_height
      public virtual void JsxSet_height(string height)
      {
         WObj.jsxSet_height(height);
      }

   }


}
