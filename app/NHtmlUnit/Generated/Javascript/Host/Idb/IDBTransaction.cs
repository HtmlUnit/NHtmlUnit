// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class IDBTransaction : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static IDBTransaction()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.IDBTransaction o) =>
            new IDBTransaction(o));
      }

      public IDBTransaction(com.gargoylesoftware.htmlunit.javascript.host.idb.IDBTransaction wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBTransaction WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.IDBTransaction)WrappedObject; }
      }

      public IDBTransaction()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBTransaction()) {}

   }


}
