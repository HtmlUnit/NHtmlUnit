// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MozSettingsEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static MozSettingsEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MozSettingsEvent o) =>
            new MozSettingsEvent(o));
      }

      public MozSettingsEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MozSettingsEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MozSettingsEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MozSettingsEvent)WrappedObject; }
      }

      public MozSettingsEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MozSettingsEvent()) {}

   }


}
