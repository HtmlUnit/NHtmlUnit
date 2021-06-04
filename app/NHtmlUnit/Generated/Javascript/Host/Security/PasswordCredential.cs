// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Security
{
   public partial class PasswordCredential : NHtmlUnit.Javascript.Host.Security.Credential
   {
      static PasswordCredential()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.security.PasswordCredential o) =>
            new PasswordCredential(o));
      }

      public PasswordCredential(com.gargoylesoftware.htmlunit.javascript.host.security.PasswordCredential wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.security.PasswordCredential WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.security.PasswordCredential)WrappedObject; }
      }

      public PasswordCredential()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.security.PasswordCredential()) {}

   }


}
