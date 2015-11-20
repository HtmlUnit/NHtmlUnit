// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class ValidityState : NHtmlUnit.Javascript.SimpleScriptable
   {
      static ValidityState()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.ValidityState o) =>
            new ValidityState(o));
      }

      public ValidityState(com.gargoylesoftware.htmlunit.javascript.host.html.ValidityState wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.ValidityState WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.ValidityState)WrappedObject; }
      }

      public ValidityState()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.ValidityState()) {}

   }


}
