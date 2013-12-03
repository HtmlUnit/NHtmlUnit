// Generated class v2.13.0.0, don't modify

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


      public System.String Value
      {
         get
         {
            return WObj.getValue();
         }
         set
         {
            WObj.setValue(value);
         }

      }

      public System.Boolean Selected
      {
         get
         {
            return WObj.getSelected();
         }
         set
         {
            WObj.setSelected(value);
         }

      }

      public System.Boolean DefaultSelected
      {
         get
         {
            return WObj.getDefaultSelected();
         }
      }

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
// Generating method code for jsConstructor
      public virtual void JsConstructor(string newText, string newValue, bool defaultSelected, bool selected)
      {
         WObj.jsConstructor(newText, newValue, defaultSelected, selected);
      }

   }


}
