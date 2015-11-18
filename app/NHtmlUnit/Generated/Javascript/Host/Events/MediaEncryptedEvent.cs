// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MediaEncryptedEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static MediaEncryptedEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MediaEncryptedEvent o) =>
            new MediaEncryptedEvent(o));
      }

      public MediaEncryptedEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MediaEncryptedEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MediaEncryptedEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MediaEncryptedEvent)WrappedObject; }
      }

      public MediaEncryptedEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MediaEncryptedEvent()) {}

   }


}
