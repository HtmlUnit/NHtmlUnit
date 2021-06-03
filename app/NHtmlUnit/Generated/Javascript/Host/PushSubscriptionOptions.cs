// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class PushSubscriptionOptions : NHtmlUnit.Javascript.SimpleScriptable
   {
      static PushSubscriptionOptions()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.PushSubscriptionOptions o) =>
            new PushSubscriptionOptions(o));
      }

      public PushSubscriptionOptions(com.gargoylesoftware.htmlunit.javascript.host.PushSubscriptionOptions wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.PushSubscriptionOptions WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.PushSubscriptionOptions)WrappedObject; }
      }

      public PushSubscriptionOptions()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.PushSubscriptionOptions()) {}

   }


}
