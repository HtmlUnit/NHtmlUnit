// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLInlineQuotationElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLInlineQuotationElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInlineQuotationElement o) =>
            new HTMLInlineQuotationElement(o));
      }

      public HTMLInlineQuotationElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInlineQuotationElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInlineQuotationElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInlineQuotationElement)WrappedObject; }
      }

      public HTMLInlineQuotationElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInlineQuotationElement()) {}


      public System.String Cite
      {
         get
         {
            return WObj.getCite();
         }
         set
         {
            WObj.setCite(value);
         }

      }

      public System.String DateTime
      {
         get
         {
            return WObj.getDateTime();
         }
         set
         {
            WObj.setDateTime(value);
         }

      }
   }


}
