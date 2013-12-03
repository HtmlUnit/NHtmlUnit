// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLBlockQuoteElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLBlockQuoteElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBlockQuoteElement o) =>
            new HTMLBlockQuoteElement(o));
      }

      public HTMLBlockQuoteElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBlockQuoteElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBlockQuoteElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBlockQuoteElement)WrappedObject; }
      }

      public HTMLBlockQuoteElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBlockQuoteElement()) {}


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
