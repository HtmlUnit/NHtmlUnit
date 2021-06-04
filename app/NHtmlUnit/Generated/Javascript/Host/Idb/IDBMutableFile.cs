// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Idb
{
   public partial class IDBMutableFile : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static IDBMutableFile()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.idb.IDBMutableFile o) =>
            new IDBMutableFile(o));
      }

      public IDBMutableFile(com.gargoylesoftware.htmlunit.javascript.host.idb.IDBMutableFile wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBMutableFile WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.idb.IDBMutableFile)WrappedObject; }
      }

      public IDBMutableFile()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.idb.IDBMutableFile()) {}

   }


}
