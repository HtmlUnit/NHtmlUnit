// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Arrays
{
   public partial class SharedArrayBuffer : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SharedArrayBuffer()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.arrays.SharedArrayBuffer o) =>
            new SharedArrayBuffer(o));
      }

      public SharedArrayBuffer(com.gargoylesoftware.htmlunit.javascript.host.arrays.SharedArrayBuffer wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.arrays.SharedArrayBuffer WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.arrays.SharedArrayBuffer)WrappedObject; }
      }

      public SharedArrayBuffer()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.arrays.SharedArrayBuffer()) {}


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

   }


}
