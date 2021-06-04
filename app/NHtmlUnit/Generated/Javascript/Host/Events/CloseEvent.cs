// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class CloseEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static CloseEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.CloseEvent o) =>
            new CloseEvent(o));
      }

      public CloseEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.CloseEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.CloseEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.CloseEvent)WrappedObject; }
      }

      public CloseEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.CloseEvent()) {}


      public System.Int32 Code
      {
         get
         {
            return WObj.getCode();
         }
         set
         {
            WObj.setCode(value);
         }

      }

      public System.String Reason
      {
         get
         {
            return WObj.getReason();
         }
         set
         {
            WObj.setReason(value);
         }

      }
// Generating method code for initCloseEvent
      public virtual void InitCloseEvent(string type, bool bubbles, bool cancelable, bool wasClean, int reasonCode, string reason)
      {
         WObj.initCloseEvent(type, bubbles, cancelable, wasClean, reasonCode, reason);
      }

// Generating method code for isWasClean
      public virtual bool IsWasClean()
      {
         return WObj.isWasClean();
      }

   }


}
