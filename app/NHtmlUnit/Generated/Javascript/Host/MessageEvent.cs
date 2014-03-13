// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class MessageEvent : NHtmlUnit.Javascript.Host.Event
   {
      static MessageEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.MessageEvent o) =>
            new MessageEvent(o));
      }

      public MessageEvent(com.gargoylesoftware.htmlunit.javascript.host.MessageEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.MessageEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.MessageEvent)WrappedObject; }
      }

      public MessageEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.MessageEvent()) {}

      public MessageEvent(object data)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.MessageEvent(data)) {}


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

// Generating method code for initMessageEvent
      public virtual void InitMessageEvent(string type, bool canBubble, bool cancelable, string data, string origin, string lastEventId, NHtmlUnit.Javascript.Host.Window source)
      {
         WObj.initMessageEvent(type, canBubble, cancelable, data, origin, lastEventId, (com.gargoylesoftware.htmlunit.javascript.host.Window)source.WrappedObject);
      }

   }


}
