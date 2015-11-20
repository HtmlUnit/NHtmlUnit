// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class BlobEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static BlobEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.BlobEvent o) =>
            new BlobEvent(o));
      }

      public BlobEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.BlobEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.BlobEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.BlobEvent)WrappedObject; }
      }

      public BlobEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.BlobEvent()) {}

   }


}
