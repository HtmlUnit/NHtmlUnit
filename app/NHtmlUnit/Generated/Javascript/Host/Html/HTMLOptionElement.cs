// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLOptionElement : NHtmlUnit.Javascript.Host.FormChild, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLOptionElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionElement o) =>
            new HTMLOptionElement(o));
      }

      public HTMLOptionElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionElement)WrappedObject; }
      }

      public HTMLOptionElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionElement()) {}

// Generating method code for jsConstructor
      public virtual void JsConstructor(string newText, string newValue, bool defaultSelected, bool selected)
      {
         WObj.jsConstructor(newText, newValue, defaultSelected, selected);
      }

// Generating method code for jsxGet_value
      public virtual string JsxGet_value()
      {
         return WObj.jsxGet_value();
      }

// Generating method code for jsxSet_value
      public virtual void JsxSet_value(string newValue)
      {
         WObj.jsxSet_value(newValue);
      }

// Generating method code for jsxSet_text
      public virtual void JsxSet_text(string newText)
      {
         WObj.jsxSet_text(newText);
      }

// Generating method code for jsxGet_selected
      public virtual bool JsxGet_selected()
      {
         return WObj.jsxGet_selected();
      }

// Generating method code for jsxSet_selected
      public virtual void JsxSet_selected(bool selected)
      {
         WObj.jsxSet_selected(selected);
      }

// Generating method code for jsxGet_defaultSelected
      public virtual bool JsxGet_defaultSelected()
      {
         return WObj.jsxGet_defaultSelected();
      }

// Generating method code for jsxGet_label
      public virtual string JsxGet_label()
      {
         return WObj.jsxGet_label();
      }

// Generating method code for jsxSet_label
      public virtual void JsxSet_label(string label)
      {
         WObj.jsxSet_label(label);
      }

   }


}
