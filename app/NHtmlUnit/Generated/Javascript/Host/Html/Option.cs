// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class Option : NHtmlUnit.Javascript.Host.Html.HTMLOptionElement
   {
      static Option()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.Option o) =>
            new Option(o));
      }

      public Option(com.gargoylesoftware.htmlunit.javascript.host.html.Option wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.Option WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.Option)WrappedObject; }
      }

      public Option()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.Option()) {}

   }


}
