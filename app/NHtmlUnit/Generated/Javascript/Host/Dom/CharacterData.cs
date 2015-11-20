// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class CharacterData : NHtmlUnit.Javascript.Host.Dom.Node
   {
      static CharacterData()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.CharacterData o) =>
            new CharacterData(o));
      }

      public CharacterData(com.gargoylesoftware.htmlunit.javascript.host.dom.CharacterData wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.CharacterData WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.CharacterData)WrappedObject; }
      }

      public CharacterData()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.CharacterData()) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for appendData
      public virtual void AppendData(string arg)
      {
         WObj.appendData(arg);
      }

// Generating method code for deleteData
      public virtual void DeleteData(int offset, int count)
      {
         WObj.deleteData(offset, count);
      }

// Generating method code for insertData
      public virtual void InsertData(int offset, string arg)
      {
         WObj.insertData(offset, arg);
      }

// Generating method code for replaceData
      public virtual void ReplaceData(int offset, int count, string arg)
      {
         WObj.replaceData(offset, count, arg);
      }

// Generating method code for substringData
      public virtual string SubstringData(int offset, int count)
      {
         return WObj.substringData(offset, count);
      }

// Generating method code for getData
      public virtual object GetData()
      {
         return WObj.getData();
      }

// Generating method code for setData
      public virtual void SetData(string newValue)
      {
         WObj.setData(newValue);
      }

   }


}
