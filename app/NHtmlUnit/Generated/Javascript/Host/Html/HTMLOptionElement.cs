// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLOptionElement : NHtmlUnit.Javascript.Host.Html.FormChild, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
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

      public System.String DataFld
      {
         get
         {
            return WObj.getDataFld();
         }
         set
         {
            WObj.setDataFld(value);
         }

      }

      public System.String DataFormatAs
      {
         get
         {
            return WObj.getDataFormatAs();
         }
         set
         {
            WObj.setDataFormatAs(value);
         }

      }

      public System.String DataSrc
      {
         get
         {
            return WObj.getDataSrc();
         }
         set
         {
            WObj.setDataSrc(value);
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
      public virtual void JsConstructor(string newText, string newValue, bool defaultSelected, bool selected)
      {
         WObj.jsConstructor(newText, newValue, defaultSelected, selected);
      }

   }


}
