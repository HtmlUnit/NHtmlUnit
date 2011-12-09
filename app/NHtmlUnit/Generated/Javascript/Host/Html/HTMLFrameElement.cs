// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLFrameElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLFrameElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameElement o) =>
            new HTMLFrameElement(o));
      }

      public HTMLFrameElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameElement)WrappedObject; }
      }

      public HTMLFrameElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameElement()) {}

// Generating method code for jsxGet_src
      public virtual string JsxGet_src()
      {
         return WObj.jsxGet_src();
      }

// Generating method code for jsxGet_contentDocument
      public virtual NHtmlUnit.Javascript.Host.Html.DocumentProxy JsxGet_contentDocument()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.DocumentProxy>(WObj.jsxGet_contentDocument());
      }

// Generating method code for jsxGet_contentWindow
      public virtual NHtmlUnit.Javascript.Host.WindowProxy JsxGet_contentWindow()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.WindowProxy>(WObj.jsxGet_contentWindow());
      }

// Generating method code for jsxSet_src
      public virtual void JsxSet_src(string src)
      {
         WObj.jsxSet_src(src);
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

// Generating method code for jsxSet_onload
      public virtual void JsxSet_onload(object eventHandler)
      {
         WObj.jsxSet_onload(eventHandler);
      }

// Generating method code for jsxGet_onload
      public virtual object JsxGet_onload()
      {
         return WObj.jsxGet_onload();
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

   }


}
