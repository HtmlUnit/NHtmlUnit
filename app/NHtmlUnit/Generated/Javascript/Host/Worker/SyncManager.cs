// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Worker
{
   public partial class SyncManager : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SyncManager()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.worker.SyncManager o) =>
            new SyncManager(o));
      }

      public SyncManager(com.gargoylesoftware.htmlunit.javascript.host.worker.SyncManager wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.worker.SyncManager WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.worker.SyncManager)WrappedObject; }
      }

      public SyncManager()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.worker.SyncManager()) {}

   }


}
