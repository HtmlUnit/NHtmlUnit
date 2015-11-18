// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class StorageEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static StorageEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.StorageEvent o) =>
            new StorageEvent(o));
      }

      public StorageEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.StorageEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.StorageEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.StorageEvent)WrappedObject; }
      }

      public StorageEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.StorageEvent()) {}

   }


}
