// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Arrays
{
   public partial class Int8Array : NHtmlUnit.Javascript.Host.Arrays.ArrayBufferViewBase
   {
      static Int8Array()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.arrays.Int8Array o) =>
            new Int8Array(o));
      }

      public Int8Array(com.gargoylesoftware.htmlunit.javascript.host.arrays.Int8Array wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.arrays.Int8Array WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.arrays.Int8Array)WrappedObject; }
      }

      public Int8Array()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.arrays.Int8Array()) {}

   }


}
