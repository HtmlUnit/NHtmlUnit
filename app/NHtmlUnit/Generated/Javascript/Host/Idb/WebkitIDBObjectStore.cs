// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class WebkitIDBObjectStore : NHtmlUnit.Javascript.Host.Idb.IDBObjectStore
   {
      static WebkitIDBObjectStore()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBObjectStore o) =>
            new WebkitIDBObjectStore(o));
      }

      public WebkitIDBObjectStore(com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBObjectStore wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBObjectStore WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBObjectStore)WrappedObject; }
      }

      public WebkitIDBObjectStore()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBObjectStore()) {}

   }


}
