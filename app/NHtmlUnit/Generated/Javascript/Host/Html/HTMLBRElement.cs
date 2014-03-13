// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLBRElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLBRElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBRElement o) =>
            new HTMLBRElement(o));
      }

      public HTMLBRElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBRElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBRElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBRElement)WrappedObject; }
      }

      public HTMLBRElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBRElement()) {}


      public System.String Clear
      {
         get
         {
            return WObj.getClear();
         }
         set
         {
            WObj.setClear(value);
         }

      }
   }


}
