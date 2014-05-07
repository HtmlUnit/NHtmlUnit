// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Arrays
{
   public partial class Int16Array : NHtmlUnit.Javascript.Host.Arrays.ArrayBufferViewBase
   {
      static Int16Array()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.arrays.Int16Array o) =>
            new Int16Array(o));
      }

      public Int16Array(com.gargoylesoftware.htmlunit.javascript.host.arrays.Int16Array wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.arrays.Int16Array WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.arrays.Int16Array)WrappedObject; }
      }

      public Int16Array()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.arrays.Int16Array()) {}

   }


}
