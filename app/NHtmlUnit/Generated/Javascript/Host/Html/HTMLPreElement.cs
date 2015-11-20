// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLPreElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLPreElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPreElement o) =>
            new HTMLPreElement(o));
      }

      public HTMLPreElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPreElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPreElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPreElement)WrappedObject; }
      }

      public HTMLPreElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPreElement()) {}


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

      public System.Object Width_js
      {
         get
         {
            return WObj.getWidth_js();
         }
      }
   }


}
