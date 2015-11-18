// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class ApplicationCacheErrorEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static ApplicationCacheErrorEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.ApplicationCacheErrorEvent o) =>
            new ApplicationCacheErrorEvent(o));
      }

      public ApplicationCacheErrorEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.ApplicationCacheErrorEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.ApplicationCacheErrorEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.ApplicationCacheErrorEvent)WrappedObject; }
      }

      public ApplicationCacheErrorEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.ApplicationCacheErrorEvent()) {}

   }


}
