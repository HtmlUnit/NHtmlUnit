// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDDElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLDDElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDDElement o) =>
            new HTMLDDElement(o));
      }

      public HTMLDDElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDDElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDDElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDDElement)WrappedObject; }
      }

      public HTMLDDElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDDElement()) {}

// Generating method code for isNoWrap
      public virtual bool IsNoWrap()
      {
         return WObj.isNoWrap();
      }

   }


}
