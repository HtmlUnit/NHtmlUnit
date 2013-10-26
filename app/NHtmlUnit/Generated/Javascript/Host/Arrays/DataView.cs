// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Arrays
{
   public partial class DataView : NHtmlUnit.Javascript.Host.Arrays.ArrayBufferView
   {
      static DataView()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.arrays.DataView o) =>
            new DataView(o));
      }

      public DataView(com.gargoylesoftware.htmlunit.javascript.host.arrays.DataView wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.arrays.DataView WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.arrays.DataView)WrappedObject; }
      }

      public DataView()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.arrays.DataView()) {}

// Generating method code for setInt8
      public virtual void SetInt8(int byteOffset, int value)
      {
         WObj.setInt8(byteOffset, value);
      }

// Generating method code for setInt16
      public virtual void SetInt16(int byteOffset, int value, bool littleEndian)
      {
         WObj.setInt16(byteOffset, value, littleEndian);
      }

// Generating method code for setInt32
      public virtual void SetInt32(int byteOffset, int value, bool littleEndian)
      {
         WObj.setInt32(byteOffset, value, littleEndian);
      }

// Generating method code for constructor
      public virtual void Constructor(NHtmlUnit.Javascript.Host.Arrays.ArrayBuffer array, int byteOffset, object length)
      {
         WObj.constructor((com.gargoylesoftware.htmlunit.javascript.host.arrays.ArrayBuffer)array.WrappedObject, byteOffset, length);
      }

// Generating method code for getInt8
      public virtual System.Byte GetInt8(int byteOffset)
      {
         return WObj.getInt8(byteOffset);
      }

// Generating method code for getInt16
      public virtual System.Int16 GetInt16(int byteOffset, bool littleEndian)
      {
         return WObj.getInt16(byteOffset, littleEndian);
      }

// Generating method code for getInt32
      public virtual int GetInt32(int byteOffset, bool littleEndian)
      {
         return WObj.getInt32(byteOffset, littleEndian);
      }

// Generating method code for getUint8
      public virtual int GetUint8(int byteOffset)
      {
         return WObj.getUint8(byteOffset);
      }

// Generating method code for setUint8
      public virtual void SetUint8(int byteOffset, int value)
      {
         WObj.setUint8(byteOffset, value);
      }

// Generating method code for getUint16
      public virtual int GetUint16(int byteOffset, bool littleEndian)
      {
         return WObj.getUint16(byteOffset, littleEndian);
      }

// Generating method code for setUint16
      public virtual void SetUint16(int byteOffset, int value, bool littleEndian)
      {
         WObj.setUint16(byteOffset, value, littleEndian);
      }

// Generating method code for getUint32
      public virtual System.Int64 GetUint32(int byteOffset, bool littleEndian)
      {
         return WObj.getUint32(byteOffset, littleEndian);
      }

// Generating method code for setUint32
      public virtual void SetUint32(int byteOffset, int value, bool littleEndian)
      {
         WObj.setUint32(byteOffset, value, littleEndian);
      }

// Generating method code for getFloat32
      public virtual System.Single GetFloat32(int byteOffset, bool littleEndian)
      {
         return WObj.getFloat32(byteOffset, littleEndian);
      }

// Generating method code for setFloat32
      public virtual void SetFloat32(int byteOffset, System.Double value, bool littleEndian)
      {
         WObj.setFloat32(byteOffset, value, littleEndian);
      }

// Generating method code for getFloat64
      public virtual System.Double GetFloat64(int byteOffset, bool littleEndian)
      {
         return WObj.getFloat64(byteOffset, littleEndian);
      }

// Generating method code for setFloat64
      public virtual void SetFloat64(int byteOffset, System.Double value, bool littleEndian)
      {
         WObj.setFloat64(byteOffset, value, littleEndian);
      }

   }


}
