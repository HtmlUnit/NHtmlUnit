// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class IDBOpenDBRequest : NHtmlUnit.Javascript.Host.Idb.IDBRequest
   {
      static IDBOpenDBRequest()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.IDBOpenDBRequest o) =>
            new IDBOpenDBRequest(o));
      }

      public IDBOpenDBRequest(com.gargoylesoftware.htmlunit.javascript.host.idb.IDBOpenDBRequest wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBOpenDBRequest WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.IDBOpenDBRequest)WrappedObject; }
      }

      public IDBOpenDBRequest()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBOpenDBRequest()) {}

   }


}
