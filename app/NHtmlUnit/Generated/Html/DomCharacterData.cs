// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class DomCharacterData : NHtmlUnit.Html.DomNode, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.ICharacterData
   {
      static DomCharacterData()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.DomCharacterData o) =>
            new DomCharacterData(o));
      }

      public DomCharacterData(com.gargoylesoftware.htmlunit.html.DomCharacterData wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.DomCharacterData WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.DomCharacterData)WrappedObject; }
      }


      public System.String Data
      {
         get
         {
            return WObj.getData();
         }
         set
         {
            WObj.setData(value);
         }

      }

      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for appendData
      public virtual void AppendData(string newData)
      {
         WObj.appendData(newData);
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

   }


}
