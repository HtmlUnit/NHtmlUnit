// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class IDBDatabase : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static IDBDatabase()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.IDBDatabase o) =>
            new IDBDatabase(o));
      }

      public IDBDatabase(com.gargoylesoftware.htmlunit.javascript.host.idb.IDBDatabase wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBDatabase WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.IDBDatabase)WrappedObject; }
      }

      public IDBDatabase()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBDatabase()) {}

   }


}
