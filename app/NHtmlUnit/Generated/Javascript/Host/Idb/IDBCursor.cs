// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class IDBCursor : NHtmlUnit.Javascript.SimpleScriptable
   {
      static IDBCursor()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.IDBCursor o) =>
            new IDBCursor(o));
      }

      public IDBCursor(com.gargoylesoftware.htmlunit.javascript.host.idb.IDBCursor wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBCursor WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.IDBCursor)WrappedObject; }
      }

      public IDBCursor()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBCursor()) {}

   }


}
