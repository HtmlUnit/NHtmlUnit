// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLNextIdElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLNextIdElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLNextIdElement o) =>
            new HTMLNextIdElement(o));
      }

      public HTMLNextIdElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLNextIdElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLNextIdElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLNextIdElement)WrappedObject; }
      }

      public HTMLNextIdElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLNextIdElement()) {}

   }


}
