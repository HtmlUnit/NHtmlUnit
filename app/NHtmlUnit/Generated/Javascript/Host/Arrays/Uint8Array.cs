// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Arrays
{
   public partial class Uint8Array : NHtmlUnit.Javascript.Host.Arrays.ArrayBufferViewBase
   {
      static Uint8Array()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint8Array o) =>
            new Uint8Array(o));
      }

      public Uint8Array(com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint8Array wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint8Array WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint8Array)WrappedObject; }
      }

      public Uint8Array()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint8Array()) {}

   }


}
