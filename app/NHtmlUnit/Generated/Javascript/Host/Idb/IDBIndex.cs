// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class IDBIndex : NHtmlUnit.Javascript.SimpleScriptable
   {
      static IDBIndex()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.IDBIndex o) =>
            new IDBIndex(o));
      }

      public IDBIndex(com.gargoylesoftware.htmlunit.javascript.host.idb.IDBIndex wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBIndex WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.IDBIndex)WrappedObject; }
      }

      public IDBIndex()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBIndex()) {}

   }


}
