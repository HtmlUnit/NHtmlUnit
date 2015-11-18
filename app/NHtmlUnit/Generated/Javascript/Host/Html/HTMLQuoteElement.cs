// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLQuoteElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLQuoteElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLQuoteElement o) =>
            new HTMLQuoteElement(o));
      }

      public HTMLQuoteElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLQuoteElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLQuoteElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLQuoteElement)WrappedObject; }
      }

      public HTMLQuoteElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLQuoteElement()) {}


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
   }


}
