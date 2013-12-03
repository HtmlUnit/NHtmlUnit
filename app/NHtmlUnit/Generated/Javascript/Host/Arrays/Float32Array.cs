// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Arrays
{
   public partial class Float32Array : NHtmlUnit.Javascript.Host.Arrays.ArrayBufferViewBase
   {
      static Float32Array()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.arrays.Float32Array o) =>
            new Float32Array(o));
      }

      public Float32Array(com.gargoylesoftware.htmlunit.javascript.host.arrays.Float32Array wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.arrays.Float32Array WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.arrays.Float32Array)WrappedObject; }
      }

      public Float32Array()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.arrays.Float32Array()) {}

   }


}
