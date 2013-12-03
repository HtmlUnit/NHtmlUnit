// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Arrays
{
   public partial class ArrayBufferView : NHtmlUnit.Javascript.SimpleScriptable
   {
      static ArrayBufferView()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBufferView o) =>
            new ArrayBufferView(o));
      }

      public ArrayBufferView(com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBufferView wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBufferView WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBufferView)WrappedObject; }
      }

      public ArrayBufferView()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBufferView()) {}


      public NHtmlUnit.Javascript.Host.Arrays.ArrayBuffer Buffer
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Arrays.ArrayBuffer>(
               WObj.getBuffer());
         }
      }


      public System.Int32 ByteLength
      {
         get
         {
            return WObj.getByteLength();
         }
      }

      public System.Int32 ByteOffset
      {
         get
         {
            return WObj.getByteOffset();
         }
      }
   }


}
