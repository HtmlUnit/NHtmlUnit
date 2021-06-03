// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Crypto
{
   public partial class SubtleCrypto : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SubtleCrypto()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.crypto.SubtleCrypto o) =>
            new SubtleCrypto(o));
      }

      public SubtleCrypto(com.gargoylesoftware.htmlunit.javascript.host.crypto.SubtleCrypto wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.crypto.SubtleCrypto WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.crypto.SubtleCrypto)WrappedObject; }
      }

      public SubtleCrypto()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.crypto.SubtleCrypto()) {}

// Generating method code for encrypt
      public virtual NHtmlUnit.Javascript.Host.Promise Encrypt()
      {
         var arg = WObj.encrypt();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Promise>(arg);
      }

// Generating method code for decrypt
      public virtual NHtmlUnit.Javascript.Host.Promise Decrypt()
      {
         var arg = WObj.decrypt();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Promise>(arg);
      }

// Generating method code for sign
      public virtual NHtmlUnit.Javascript.Host.Promise Sign()
      {
         var arg = WObj.sign();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Promise>(arg);
      }

// Generating method code for verify
      public virtual NHtmlUnit.Javascript.Host.Promise Verify()
      {
         var arg = WObj.verify();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Promise>(arg);
      }

// Generating method code for digest
      public virtual NHtmlUnit.Javascript.Host.Promise Digest()
      {
         var arg = WObj.digest();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Promise>(arg);
      }

// Generating method code for generateKey
      public virtual NHtmlUnit.Javascript.Host.Promise GenerateKey()
      {
         var arg = WObj.generateKey();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Promise>(arg);
      }

// Generating method code for deriveKey
      public virtual NHtmlUnit.Javascript.Host.Promise DeriveKey()
      {
         var arg = WObj.deriveKey();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Promise>(arg);
      }

// Generating method code for importKey
      public virtual NHtmlUnit.Javascript.Host.Promise ImportKey()
      {
         var arg = WObj.importKey();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Promise>(arg);
      }

// Generating method code for exportKey
      public virtual NHtmlUnit.Javascript.Host.Promise ExportKey()
      {
         var arg = WObj.exportKey();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Promise>(arg);
      }

// Generating method code for wrapKey
      public virtual NHtmlUnit.Javascript.Host.Promise WrapKey()
      {
         var arg = WObj.wrapKey();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Promise>(arg);
      }

// Generating method code for unwrapKey
      public virtual NHtmlUnit.Javascript.Host.Promise UnwrapKey()
      {
         var arg = WObj.unwrapKey();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Promise>(arg);
      }

   }


}
