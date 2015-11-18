// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class TextEvent : NHtmlUnit.Javascript.Host.Events.UIEvent
   {
      static TextEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.TextEvent o) =>
            new TextEvent(o));
      }

      public TextEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.TextEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.TextEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.TextEvent)WrappedObject; }
      }

      public TextEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.TextEvent()) {}

   }


}
