// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Notification : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static Notification()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Notification o) =>
            new Notification(o));
      }

      public Notification(com.gargoylesoftware.htmlunit.javascript.host.Notification wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Notification WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Notification)WrappedObject; }
      }

      public Notification()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Notification()) {}

// Generating method code for jsConstructor
      public virtual void JsConstructor(string title)
      {
         WObj.jsConstructor(title);
      }

   }


}
