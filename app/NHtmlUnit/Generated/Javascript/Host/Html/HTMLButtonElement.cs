// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLButtonElement : NHtmlUnit.Javascript.Host.Html.FormField, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLButtonElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLButtonElement o) =>
            new HTMLButtonElement(o));
      }

      public HTMLButtonElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLButtonElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLButtonElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLButtonElement)WrappedObject; }
      }

      public HTMLButtonElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLButtonElement()) {}


      public System.String Type
      {
         get
         {
            return WObj.getType();
         }
         set
         {
            WObj.setType(value);
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
   }


}
