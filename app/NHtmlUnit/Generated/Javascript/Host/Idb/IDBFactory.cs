// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class IDBFactory : NHtmlUnit.Javascript.SimpleScriptable
   {
      static IDBFactory()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.IDBFactory o) =>
            new IDBFactory(o));
      }

      public IDBFactory(com.gargoylesoftware.htmlunit.javascript.host.idb.IDBFactory wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBFactory WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.IDBFactory)WrappedObject; }
      }

      public IDBFactory()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBFactory()) {}

   }


}
