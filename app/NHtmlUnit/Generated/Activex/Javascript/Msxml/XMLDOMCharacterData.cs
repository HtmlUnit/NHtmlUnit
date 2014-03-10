// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class XMLDOMCharacterData : NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode
   {
      static XMLDOMCharacterData()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMCharacterData o) =>
            new XMLDOMCharacterData(o));
      }

      public XMLDOMCharacterData(com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMCharacterData wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMCharacterData WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMCharacterData)WrappedObject; }
      }

      public XMLDOMCharacterData()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMCharacterData()) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for appendData
      public virtual void AppendData(string data)
      {
         WObj.appendData(data);
      }

// Generating method code for deleteData
      public virtual void DeleteData(int offset, int count)
      {
         WObj.deleteData(offset, count);
      }

// Generating method code for insertData
      public virtual void InsertData(int offset, string data)
      {
         WObj.insertData(offset, data);
      }

// Generating method code for replaceData
      public virtual void ReplaceData(int offset, int count, string data)
      {
         WObj.replaceData(offset, count, data);
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
      public virtual void SetData(string newData)
      {
         WObj.setData(newData);
      }

   }


}
