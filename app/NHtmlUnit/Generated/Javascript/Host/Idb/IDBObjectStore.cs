// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class IDBObjectStore : NHtmlUnit.Javascript.SimpleScriptable
   {
      static IDBObjectStore()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.IDBObjectStore o) =>
            new IDBObjectStore(o));
      }

      public IDBObjectStore(com.gargoylesoftware.htmlunit.javascript.host.idb.IDBObjectStore wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBObjectStore WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.IDBObjectStore)WrappedObject; }
      }

      public IDBObjectStore()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBObjectStore()) {}

   }


}
