// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDetailsElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLDetailsElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDetailsElement o) =>
            new HTMLDetailsElement(o));
      }

      public HTMLDetailsElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDetailsElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDetailsElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDetailsElement)WrappedObject; }
      }

      public HTMLDetailsElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDetailsElement()) {}

// Generating method code for isOpen
      public virtual bool IsOpen()
      {
         return WObj.isOpen();
      }

   }


}
