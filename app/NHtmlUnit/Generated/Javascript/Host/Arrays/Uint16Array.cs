// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Arrays
{
   public partial class Uint16Array : NHtmlUnit.Javascript.Host.Arrays.ArrayBufferViewBase
   {
      static Uint16Array()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint16Array o) =>
            new Uint16Array(o));
      }

      public Uint16Array(com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint16Array wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint16Array WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint16Array)WrappedObject; }
      }

      public Uint16Array()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint16Array()) {}

   }


}
