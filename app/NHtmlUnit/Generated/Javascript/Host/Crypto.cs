// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Crypto
{
   public partial class Crypto : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Crypto()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.crypto.Crypto o) =>
            new Crypto(o));
      }

      public Crypto(com.gargoylesoftware.htmlunit.javascript.host.crypto.Crypto wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.crypto.Crypto WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.crypto.Crypto)WrappedObject; }
      }

      public Crypto()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.crypto.Crypto()) {}

      public Crypto(NHtmlUnit.Javascript.Host.Window window)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.crypto.Crypto((com.gargoylesoftware.htmlunit.javascript.host.Window)window.WrappedObject)) {}


      public NHtmlUnit.Javascript.Host.Crypto.SubtleCrypto Subtle
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Crypto.SubtleCrypto>(
               WObj.getSubtle());
         }
      }

// Generating method code for getRandomValues
      public virtual IList<System.Object> GetRandomValues(net.sourceforge.htmlunit.corejs.javascript.typedarrays.NativeTypedArrayView array)
      {

return new ShallowListWrapper<System.Object>(WObj.getRandomValues(array));
      }

   }


}
