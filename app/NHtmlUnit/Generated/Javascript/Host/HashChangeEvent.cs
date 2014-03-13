// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class HashChangeEvent : NHtmlUnit.Javascript.Host.Event
   {
      static HashChangeEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.HashChangeEvent o) =>
            new HashChangeEvent(o));
      }

      public HashChangeEvent(com.gargoylesoftware.htmlunit.javascript.host.HashChangeEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.HashChangeEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.HashChangeEvent)WrappedObject; }
      }

      public HashChangeEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.HashChangeEvent()) {}

      public HashChangeEvent(NHtmlUnit.Javascript.SimpleScriptable scriptable, string type, string oldURL, string newURL)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.HashChangeEvent((com.gargoylesoftware.htmlunit.javascript.SimpleScriptable)scriptable.WrappedObject, type, oldURL, newURL)) {}


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
