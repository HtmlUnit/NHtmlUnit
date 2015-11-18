// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLFormControlsCollection : NHtmlUnit.Javascript.Host.Html.HTMLCollection
   {
      static HTMLFormControlsCollection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFormControlsCollection o) =>
            new HTMLFormControlsCollection(o));
      }

      public HTMLFormControlsCollection(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFormControlsCollection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFormControlsCollection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFormControlsCollection)WrappedObject; }
      }

      public HTMLFormControlsCollection()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFormControlsCollection()) {}

   }


}
