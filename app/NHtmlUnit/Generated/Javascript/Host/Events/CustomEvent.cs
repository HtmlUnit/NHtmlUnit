// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class CustomEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static CustomEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.CustomEvent o) =>
            new CustomEvent(o));
      }

      public CustomEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.CustomEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.CustomEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.CustomEvent)WrappedObject; }
      }

      public CustomEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.CustomEvent()) {}


      public System.Object Detail
      {
         get
         {
            return WObj.getDetail();
         }
      }
// Generating method code for initCustomEvent
      public virtual void InitCustomEvent(string type, bool bubbles, bool cancelable, object detail)
      {
         WObj.initCustomEvent(type, bubbles, cancelable, detail);
      }

   }


}
