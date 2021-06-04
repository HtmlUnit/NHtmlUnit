// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class CustomElementRegistry : NHtmlUnit.Javascript.SimpleScriptable
   {
      static CustomElementRegistry()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.CustomElementRegistry o) =>
            new CustomElementRegistry(o));
      }

      public CustomElementRegistry(com.gargoylesoftware.htmlunit.javascript.host.dom.CustomElementRegistry wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.CustomElementRegistry WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.CustomElementRegistry)WrappedObject; }
      }

      public CustomElementRegistry()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.CustomElementRegistry()) {}

   }


}
