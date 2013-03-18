// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLButtonElement : NHtmlUnit.Javascript.Host.FormField, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
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

   }


}
