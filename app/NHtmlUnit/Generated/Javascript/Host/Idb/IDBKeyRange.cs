// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class IDBKeyRange : NHtmlUnit.Javascript.SimpleScriptable
   {
      static IDBKeyRange()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.IDBKeyRange o) =>
            new IDBKeyRange(o));
      }

      public IDBKeyRange(com.gargoylesoftware.htmlunit.javascript.host.idb.IDBKeyRange wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBKeyRange WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.IDBKeyRange)WrappedObject; }
      }

      public IDBKeyRange()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBKeyRange()) {}

   }


}
