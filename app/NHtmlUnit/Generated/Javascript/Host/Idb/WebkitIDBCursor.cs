// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class WebkitIDBCursor : NHtmlUnit.Javascript.Host.Idb.IDBCursor
   {
      static WebkitIDBCursor()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBCursor o) =>
            new WebkitIDBCursor(o));
      }

      public WebkitIDBCursor(com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBCursor wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBCursor WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBCursor)WrappedObject; }
      }

      public WebkitIDBCursor()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBCursor()) {}

   }


}
