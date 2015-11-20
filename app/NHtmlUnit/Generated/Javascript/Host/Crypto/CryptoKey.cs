// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Crypto
{
   public partial class CryptoKey : NHtmlUnit.Javascript.SimpleScriptable
   {
      static CryptoKey()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.crypto.CryptoKey o) =>
            new CryptoKey(o));
      }

      public CryptoKey(com.gargoylesoftware.htmlunit.javascript.host.crypto.CryptoKey wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.crypto.CryptoKey WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.crypto.CryptoKey)WrappedObject; }
      }

      public CryptoKey()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.crypto.CryptoKey()) {}

   }


}
