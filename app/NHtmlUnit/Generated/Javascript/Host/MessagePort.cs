// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class MessagePort : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static MessagePort()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.MessagePort o) =>
            new MessagePort(o));
      }

      public MessagePort(com.gargoylesoftware.htmlunit.javascript.host.MessagePort wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.MessagePort WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.MessagePort)WrappedObject; }
      }

      public MessagePort()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.MessagePort()) {}

      public MessagePort(NHtmlUnit.Javascript.Host.MessagePort port1)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.MessagePort((com.gargoylesoftware.htmlunit.javascript.host.MessagePort)port1.WrappedObject)) {}


      public System.Object Onmessage
      {
         get
         {
            return WObj.getOnmessage();
         }
         set
         {
            WObj.setOnmessage(value);
         }

      }
// Generating method code for postMessage
      public virtual void PostMessage(string message, object transfer)
      {
         WObj.postMessage(message, transfer);
      }

   }


}
