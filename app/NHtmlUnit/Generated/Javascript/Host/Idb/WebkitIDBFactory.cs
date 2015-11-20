// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class WebkitIDBFactory : NHtmlUnit.Javascript.Host.Idb.IDBFactory
   {
      static WebkitIDBFactory()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBFactory o) =>
            new WebkitIDBFactory(o));
      }

      public WebkitIDBFactory(com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBFactory wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBFactory WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBFactory)WrappedObject; }
      }

      public WebkitIDBFactory()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBFactory()) {}

   }


}
