// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Arrays
{
   public partial class ArrayBuffer : NHtmlUnit.Javascript.SimpleScriptable
   {
      static ArrayBuffer()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBuffer o) =>
            new ArrayBuffer(o));
      }

      public ArrayBuffer(com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBuffer wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBuffer WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBuffer)WrappedObject; }
      }

      public ArrayBuffer()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBuffer()) {}


      public System.Int32 ByteLength
      {
         get
         {
            return WObj.getByteLength();
         }
      }
// Generating method code for constructor
      public virtual void Constructor(int length)
      {
         WObj.constructor(length);
      }

// Generating method code for slice
      public virtual NHtmlUnit.Javascript.Host.Arrays.ArrayBuffer Slice(int begin, object end)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Arrays.ArrayBuffer>(WObj.slice(begin, end));
      }

// Generating method code for setBytes
      public virtual void SetBytes(int index, System.Byte[] array)
      {
         WObj.setBytes(index, array);
      }

   }


}
