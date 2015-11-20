// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class ClipboardEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static ClipboardEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.ClipboardEvent o) =>
            new ClipboardEvent(o));
      }

      public ClipboardEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.ClipboardEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.ClipboardEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.ClipboardEvent)WrappedObject; }
      }

      public ClipboardEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.ClipboardEvent()) {}

   }


}
