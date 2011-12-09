// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLFontElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLFontElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFontElement o) =>
            new HTMLFontElement(o));
      }

      public HTMLFontElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFontElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFontElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFontElement)WrappedObject; }
      }

      public HTMLFontElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFontElement()) {}

// Generating method code for jsxGet_color
      public virtual string JsxGet_color()
      {
         return WObj.jsxGet_color();
      }

// Generating method code for jsxSet_color
      public virtual void JsxSet_color(string color)
      {
         WObj.jsxSet_color(color);
      }

// Generating method code for jsxGet_face
      public virtual string JsxGet_face()
      {
         return WObj.jsxGet_face();
      }

// Generating method code for jsxSet_face
      public virtual void JsxSet_face(string face)
      {
         WObj.jsxSet_face(face);
      }

// Generating method code for jsxGet_size
      public virtual int JsxGet_size()
      {
         return WObj.jsxGet_size();
      }

// Generating method code for jsxSet_size
      public virtual void JsxSet_size(int size)
      {
         WObj.jsxSet_size(size);
      }

   }


}
