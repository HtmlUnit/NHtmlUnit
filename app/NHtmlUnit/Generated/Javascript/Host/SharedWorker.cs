// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class SharedWorker : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static SharedWorker()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.SharedWorker o) =>
            new SharedWorker(o));
      }

      public SharedWorker(com.gargoylesoftware.htmlunit.javascript.host.SharedWorker wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.SharedWorker WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.SharedWorker)WrappedObject; }
      }

      public SharedWorker()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.SharedWorker()) {}

   }


}
