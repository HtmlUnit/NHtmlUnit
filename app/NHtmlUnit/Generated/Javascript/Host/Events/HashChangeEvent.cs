// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class HashChangeEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static HashChangeEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.HashChangeEvent o) =>
            new HashChangeEvent(o));
      }

      public HashChangeEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.HashChangeEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.HashChangeEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.HashChangeEvent)WrappedObject; }
      }

      public HashChangeEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.HashChangeEvent()) {}

      public HashChangeEvent(NHtmlUnit.Javascript.Host.Events.EventTarget target, string type, string oldURL, string newURL)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.HashChangeEvent((com.gargoylesoftware.htmlunit.javascript.host.@event.EventTarget)target.WrappedObject, type, oldURL, newURL)) {}


      public System.Object OldURL
      {
         get
         {
            return WObj.getOldURL();
         }
      }

      public System.Object NewURL
      {
         get
         {
            return WObj.getNewURL();
         }
      }
// Generating method code for initHashChangeEvent
      public virtual void InitHashChangeEvent(string type, bool bubbles, bool cancelable, string oldURL, string newURL)
      {
         WObj.initHashChangeEvent(type, bubbles, cancelable, oldURL, newURL);
      }

   }


}
