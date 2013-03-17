// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLLegendElement : NHtmlUnit.Javascript.Host.FormChild, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
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

   }


}
