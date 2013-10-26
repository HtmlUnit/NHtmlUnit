// Generated class v2.13, don't modify

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
   }


}
