// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MozMmsEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static MozMmsEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MozMmsEvent o) =>
            new MozMmsEvent(o));
      }

      public MozMmsEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MozMmsEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MozMmsEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MozMmsEvent)WrappedObject; }
      }

      public MozMmsEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MozMmsEvent()) {}

   }


}
