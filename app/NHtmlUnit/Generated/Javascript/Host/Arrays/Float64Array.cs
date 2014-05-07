// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Arrays
{
   public partial class Float64Array : NHtmlUnit.Javascript.Host.Arrays.ArrayBufferViewBase
   {
      static Float64Array()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.arrays.Float64Array o) =>
            new Float64Array(o));
      }

      public Float64Array(com.gargoylesoftware.htmlunit.javascript.host.arrays.Float64Array wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.arrays.Float64Array WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.arrays.Float64Array)WrappedObject; }
      }

      public Float64Array()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.arrays.Float64Array()) {}

   }


}
