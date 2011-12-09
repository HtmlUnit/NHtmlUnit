// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class CharacterDataImpl : NHtmlUnit.Javascript.Host.Node
   {
      static CharacterDataImpl()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.CharacterDataImpl o) =>
            new CharacterDataImpl(o));
      }

      public CharacterDataImpl(com.gargoylesoftware.htmlunit.javascript.host.CharacterDataImpl wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.CharacterDataImpl WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.CharacterDataImpl)WrappedObject; }
      }

      public CharacterDataImpl()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.CharacterDataImpl()) {}

// Generating method code for jsxGet_data
      public virtual object JsxGet_data()
      {
         return WObj.jsxGet_data();
      }

// Generating method code for jsxSet_data
      public virtual void JsxSet_data(string newValue)
      {
         WObj.jsxSet_data(newValue);
      }

// Generating method code for jsxGet_length
      public virtual int JsxGet_length()
      {
         return WObj.jsxGet_length();
      }

// Generating method code for jsxFunction_appendData
      public virtual void JsxFunction_appendData(string arg)
      {
         WObj.jsxFunction_appendData(arg);
      }

// Generating method code for jsxFunction_deleteData
      public virtual void JsxFunction_deleteData(int offset, int count)
      {
         WObj.jsxFunction_deleteData(offset, count);
      }

// Generating method code for jsxFunction_insertData
      public virtual void JsxFunction_insertData(int offset, string arg)
      {
         WObj.jsxFunction_insertData(offset, arg);
      }

// Generating method code for jsxFunction_replaceData
      public virtual void JsxFunction_replaceData(int offset, int count, string arg)
      {
         WObj.jsxFunction_replaceData(offset, count, arg);
      }

// Generating method code for jsxFunction_substringData
      public virtual string JsxFunction_substringData(int offset, int count)
      {
         return WObj.jsxFunction_substringData(offset, count);
      }

   }


}
