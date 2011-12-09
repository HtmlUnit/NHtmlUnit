// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTableSectionElement : NHtmlUnit.Javascript.Host.RowContainer, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLTableSectionElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableSectionElement o) =>
            new HTMLTableSectionElement(o));
      }

      public HTMLTableSectionElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableSectionElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableSectionElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableSectionElement)WrappedObject; }
      }

      public HTMLTableSectionElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableSectionElement()) {}

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
