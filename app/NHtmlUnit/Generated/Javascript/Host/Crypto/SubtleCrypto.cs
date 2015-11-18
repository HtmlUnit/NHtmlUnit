// Generated class v2.19.0.0, don't modify

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

   }


}
