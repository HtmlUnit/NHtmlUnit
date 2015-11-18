// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class BeforeInstallPromptEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static BeforeInstallPromptEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.BeforeInstallPromptEvent o) =>
            new BeforeInstallPromptEvent(o));
      }

      public BeforeInstallPromptEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.BeforeInstallPromptEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.BeforeInstallPromptEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.BeforeInstallPromptEvent)WrappedObject; }
      }

      public BeforeInstallPromptEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.BeforeInstallPromptEvent()) {}

   }


}
