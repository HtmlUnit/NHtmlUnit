// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Arrays
{
   public partial class Uint32Array : NHtmlUnit.Javascript.Host.Arrays.ArrayBufferViewBase
   {
      static Uint32Array()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint32Array o) =>
            new Uint32Array(o));
      }

      public Uint32Array(com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint32Array wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint32Array WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint32Array)WrappedObject; }
      }

      public Uint32Array()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint32Array()) {}

   }


}
