// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class WebkitIDBTransaction : NHtmlUnit.Javascript.Host.Idb.IDBTransaction
   {
      static WebkitIDBTransaction()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBTransaction o) =>
            new WebkitIDBTransaction(o));
      }

      public WebkitIDBTransaction(com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBTransaction wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBTransaction WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBTransaction)WrappedObject; }
      }

      public WebkitIDBTransaction()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBTransaction()) {}

   }


}
