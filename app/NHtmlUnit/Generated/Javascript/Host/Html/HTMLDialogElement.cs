// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDialogElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLDialogElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDialogElement o) =>
            new HTMLDialogElement(o));
      }

      public HTMLDialogElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDialogElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDialogElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDialogElement)WrappedObject; }
      }

      public HTMLDialogElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDialogElement()) {}

   }


}
