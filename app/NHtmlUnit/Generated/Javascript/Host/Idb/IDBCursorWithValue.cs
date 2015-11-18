// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class IDBCursorWithValue : NHtmlUnit.Javascript.Host.Idb.IDBCursor
   {
      static IDBCursorWithValue()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.IDBCursorWithValue o) =>
            new IDBCursorWithValue(o));
      }

      public IDBCursorWithValue(com.gargoylesoftware.htmlunit.javascript.host.idb.IDBCursorWithValue wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBCursorWithValue WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.IDBCursorWithValue)WrappedObject; }
      }

      public IDBCursorWithValue()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBCursorWithValue()) {}

   }


}
