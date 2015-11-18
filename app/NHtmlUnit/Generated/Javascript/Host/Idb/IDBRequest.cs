// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class IDBRequest : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static IDBRequest()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.IDBRequest o) =>
            new IDBRequest(o));
      }

      public IDBRequest(com.gargoylesoftware.htmlunit.javascript.host.idb.IDBRequest wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBRequest WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.IDBRequest)WrappedObject; }
      }

      public IDBRequest()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBRequest()) {}

   }


}
