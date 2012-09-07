// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class MessageEvent : NHtmlUnit.Javascript.SimpleScriptable
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

// Generating method code for jsxGet_data
      public virtual object JsxGet_data()
      {
         return WObj.jsxGet_data();
      }

   }


}
