// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Arrays
{
   public partial class ArrayBufferViewBase : NHtmlUnit.Javascript.Host.Arrays.ArrayBufferView
   {
      static ArrayBufferViewBase()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBufferViewBase o) =>
            new ArrayBufferViewBase(o));
      }

      public ArrayBufferViewBase(com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBufferViewBase wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBufferViewBase WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBufferViewBase)WrappedObject; }
      }

      public ArrayBufferViewBase()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBufferViewBase()) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for set
      public virtual void Set(net.sourceforge.htmlunit.corejs.javascript.ScriptableObject sourceArray, int offset)
      {
         WObj.set(sourceArray, offset);
      }

// Generating method code for constructor
      public virtual void Constructor(object objectArg, object byteOffset, object length)
      {
         WObj.constructor(objectArg, byteOffset, length);
      }

// Generating method code for subarray
      public virtual NHtmlUnit.Javascript.Host.Arrays.ArrayBufferView Subarray(int begin, object end)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Arrays.ArrayBufferView>(WObj.subarray(begin, end));
      }

   }


}
