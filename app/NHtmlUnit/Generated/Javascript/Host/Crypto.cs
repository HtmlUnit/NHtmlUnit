// Generated class v2.19.0.0, don't modify

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

// Generating method code for getRandomValues
      public virtual void GetRandomValues(NHtmlUnit.Javascript.Host.Arrays.ArrayBufferViewBase array)
      {
         WObj.getRandomValues((com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBufferViewBase)array.WrappedObject);
      }

   }


}
