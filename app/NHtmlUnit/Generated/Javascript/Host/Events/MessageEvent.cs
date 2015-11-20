// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MessageEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static MessageEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MessageEvent o) =>
            new MessageEvent(o));
      }

      public MessageEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MessageEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MessageEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MessageEvent)WrappedObject; }
      }

      public MessageEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MessageEvent()) {}

      public MessageEvent(object data)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MessageEvent(data)) {}


      public System.Object Data
      {
         get
         {
            return WObj.getData();
         }
      }

      public System.String Origin
      {
         get
         {
            return WObj.getOrigin();
         }
      }

      public System.String LastEventId
      {
         get
         {
            return WObj.getLastEventId();
         }
      }

      public NHtmlUnit.Javascript.Host.Window Source
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Window>(
               WObj.getSource());
         }
      }


      public System.Object Ports
      {
         get
         {
            return WObj.getPorts();
         }
      }
// Generating method code for initMessageEvent
      public virtual void InitMessageEvent(string type, bool canBubble, bool cancelable, object data, string origin, string lastEventId, NHtmlUnit.Javascript.Host.Window source, object ports)
      {
         WObj.initMessageEvent(type, canBubble, cancelable, data, origin, lastEventId, (com.gargoylesoftware.htmlunit.javascript.host.Window)source.WrappedObject, ports);
      }

   }


}
