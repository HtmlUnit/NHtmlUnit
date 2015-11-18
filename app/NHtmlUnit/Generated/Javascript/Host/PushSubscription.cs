// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class PushSubscription : NHtmlUnit.Javascript.SimpleScriptable
   {
      static PushSubscription()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.PushSubscription o) =>
            new PushSubscription(o));
      }

      public PushSubscription(com.gargoylesoftware.htmlunit.javascript.host.PushSubscription wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.PushSubscription WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.PushSubscription)WrappedObject; }
      }

      public PushSubscription()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.PushSubscription()) {}

   }


}
