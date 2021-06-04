// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Security
{
   public partial class CredentialsContainer : NHtmlUnit.Javascript.SimpleScriptable
   {
      static CredentialsContainer()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.security.CredentialsContainer o) =>
            new CredentialsContainer(o));
      }

      public CredentialsContainer(com.gargoylesoftware.htmlunit.javascript.host.security.CredentialsContainer wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.security.CredentialsContainer WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.security.CredentialsContainer)WrappedObject; }
      }

      public CredentialsContainer()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.security.CredentialsContainer()) {}

   }


}
