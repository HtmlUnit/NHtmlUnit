// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Arrays
{
   public partial class Uint8ClampedArray : NHtmlUnit.Javascript.Host.Arrays.ArrayBufferViewBase
   {
      static Uint8ClampedArray()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint8ClampedArray o) =>
            new Uint8ClampedArray(o));
      }

      public Uint8ClampedArray(com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint8ClampedArray wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint8ClampedArray WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint8ClampedArray)WrappedObject; }
      }

      public Uint8ClampedArray()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.arrays.Uint8ClampedArray()) {}

   }


}
