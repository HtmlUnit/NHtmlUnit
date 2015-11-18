// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class WebkitIDBRequest : NHtmlUnit.Javascript.Host.Idb.IDBRequest
   {
      static WebkitIDBRequest()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBRequest o) =>
            new WebkitIDBRequest(o));
      }

      public WebkitIDBRequest(com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBRequest wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBRequest WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBRequest)WrappedObject; }
      }

      public WebkitIDBRequest()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBRequest()) {}

   }


}
