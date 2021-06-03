// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Security
{
   public partial class FederatedCredential : NHtmlUnit.Javascript.Host.Security.Credential
   {
      static FederatedCredential()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.security.FederatedCredential o) =>
            new FederatedCredential(o));
      }

      public FederatedCredential(com.gargoylesoftware.htmlunit.javascript.host.security.FederatedCredential wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.security.FederatedCredential WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.security.FederatedCredential)WrappedObject; }
      }

      public FederatedCredential()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.security.FederatedCredential()) {}

   }


}
