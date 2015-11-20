// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class WebkitIDBIndex : NHtmlUnit.Javascript.Host.Idb.IDBIndex
   {
      static WebkitIDBIndex()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBIndex o) =>
            new WebkitIDBIndex(o));
      }

      public WebkitIDBIndex(com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBIndex wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBIndex WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBIndex)WrappedObject; }
      }

      public WebkitIDBIndex()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.webkitIDBIndex()) {}

   }


}
