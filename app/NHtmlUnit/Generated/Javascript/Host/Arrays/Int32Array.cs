// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Arrays
{
   public partial class Int32Array : NHtmlUnit.Javascript.Host.Arrays.ArrayBufferViewBase
   {
      static Int32Array()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.arrays.Int32Array o) =>
            new Int32Array(o));
      }

      public Int32Array(com.gargoylesoftware.htmlunit.javascript.host.arrays.Int32Array wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.arrays.Int32Array WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.arrays.Int32Array)WrappedObject; }
      }

      public Int32Array()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.arrays.Int32Array()) {}

   }


}
