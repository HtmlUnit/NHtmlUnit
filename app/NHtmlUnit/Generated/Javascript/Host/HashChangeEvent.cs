// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class HashChangeEvent : NHtmlUnit.Javascript.Host.UIEvent
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

      public HashChangeEvent(NHtmlUnit.Javascript.SimpleScriptable scriptable, string type, object oldUrl, object newUrl)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.HashChangeEvent((com.gargoylesoftware.htmlunit.javascript.SimpleScriptable)scriptable.WrappedObject, type, oldUrl, newUrl)) {}

// Generating method code for jsxGet_oldURL
      public virtual object JsxGet_oldURL()
      {
         return WObj.jsxGet_oldURL();
      }

// Generating method code for jsxGet_newURL
      public virtual object JsxGet_newURL()
      {
         return WObj.jsxGet_newURL();
      }

   }


}
