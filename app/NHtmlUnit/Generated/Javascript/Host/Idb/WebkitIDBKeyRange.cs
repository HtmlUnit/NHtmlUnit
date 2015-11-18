// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class WebkitIDBKeyRange : NHtmlUnit.Javascript.Host.Idb.IDBKeyRange
   {
      static WebkitIDBKeyRange()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBKeyRange o) =>
            new WebkitIDBKeyRange(o));
      }

      public WebkitIDBKeyRange(com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBKeyRange wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBKeyRange WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBKeyRange)WrappedObject; }
      }

      public WebkitIDBKeyRange()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBKeyRange()) {}

   }


}
