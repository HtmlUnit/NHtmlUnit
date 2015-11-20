// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class WebkitIDBDatabase : NHtmlUnit.Javascript.Host.Idb.IDBDatabase
   {
      static WebkitIDBDatabase()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBDatabase o) =>
            new WebkitIDBDatabase(o));
      }

      public WebkitIDBDatabase(com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBDatabase wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBDatabase WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBDatabase)WrappedObject; }
      }

      public WebkitIDBDatabase()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBDatabase()) {}

   }


}
