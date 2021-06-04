// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLOptionElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
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


      public System.String Label
      {
         get
         {
            return WObj.getLabel();
         }
         set
         {
            WObj.setLabel(value);
         }

      }

      public System.String Text
      {
         get
         {
            return WObj.getText();
         }
         set
         {
            WObj.setText(value);
         }

      }

      public System.Int32 Index
      {
         get
         {
            return WObj.getIndex();
         }
      }
// Generating method code for jsConstructor
      public virtual void JsConstructor(object newText, string newValue, bool defaultSelected, bool selected)
      {
         WObj.jsConstructor(newText, newValue, defaultSelected, selected);
      }

// Generating method code for isSelected
      public virtual bool IsSelected()
      {
         return WObj.isSelected();
      }

// Generating method code for isDefaultSelected
      public virtual bool IsDefaultSelected()
      {
         return WObj.isDefaultSelected();
      }

   }


}
