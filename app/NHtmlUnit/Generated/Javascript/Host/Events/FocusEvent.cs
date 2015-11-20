// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class FocusEvent : NHtmlUnit.Javascript.Host.Events.UIEvent
   {
      static FocusEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.FocusEvent o) =>
            new FocusEvent(o));
      }

      public FocusEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.FocusEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.FocusEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.FocusEvent)WrappedObject; }
      }

      public FocusEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.FocusEvent()) {}

   }


}
