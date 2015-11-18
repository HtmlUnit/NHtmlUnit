// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MozContactChangeEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static MozContactChangeEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MozContactChangeEvent o) =>
            new MozContactChangeEvent(o));
      }

      public MozContactChangeEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MozContactChangeEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MozContactChangeEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MozContactChangeEvent)WrappedObject; }
      }

      public MozContactChangeEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MozContactChangeEvent()) {}

   }


}
