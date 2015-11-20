// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLLegendElement : NHtmlUnit.Javascript.Host.Html.FormChild, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLLegendElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLegendElement o) =>
            new HTMLLegendElement(o));
      }

      public HTMLLegendElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLegendElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLegendElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLegendElement)WrappedObject; }
      }

      public HTMLLegendElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLegendElement()) {}


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
   }


}
