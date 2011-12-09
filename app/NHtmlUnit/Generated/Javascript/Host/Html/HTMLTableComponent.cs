// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTableComponent : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLTableComponent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableComponent o) =>
            new HTMLTableComponent(o));
      }

      public HTMLTableComponent(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableComponent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableComponent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableComponent)WrappedObject; }
      }

      public HTMLTableComponent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableComponent()) {}

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

// Generating method code for jsxGet_vAlign
      public virtual string JsxGet_vAlign()
      {
         return WObj.jsxGet_vAlign();
      }

// Generating method code for jsxSet_vAlign
      public virtual void JsxSet_vAlign(object vAlign)
      {
         WObj.jsxSet_vAlign(vAlign);
      }

// Generating method code for jsxGet_ch
      public virtual string JsxGet_ch()
      {
         return WObj.jsxGet_ch();
      }

// Generating method code for jsxSet_ch
      public virtual void JsxSet_ch(string ch)
      {
         WObj.jsxSet_ch(ch);
      }

// Generating method code for jsxGet_chOff
      public virtual string JsxGet_chOff()
      {
         return WObj.jsxGet_chOff();
      }

// Generating method code for jsxSet_chOff
      public virtual void JsxSet_chOff(string chOff)
      {
         WObj.jsxSet_chOff(chOff);
      }

   }


}
