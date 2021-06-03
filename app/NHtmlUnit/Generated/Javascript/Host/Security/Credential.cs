// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Security
{
   public partial class Credential : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Credential()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.security.Credential o) =>
            new Credential(o));
      }

      public Credential(com.gargoylesoftware.htmlunit.javascript.host.security.Credential wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.security.Credential WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.security.Credential)WrappedObject; }
      }

      public Credential()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.security.Credential()) {}

   }


}
