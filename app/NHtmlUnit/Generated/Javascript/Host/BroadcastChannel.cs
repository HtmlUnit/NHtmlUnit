// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class BroadcastChannel : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static BroadcastChannel()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.BroadcastChannel o) =>
            new BroadcastChannel(o));
      }

      public BroadcastChannel(com.gargoylesoftware.htmlunit.javascript.host.BroadcastChannel wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.BroadcastChannel WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.BroadcastChannel)WrappedObject; }
      }

      public BroadcastChannel()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.BroadcastChannel()) {}

   }


}
