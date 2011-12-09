// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class KeyboardEvent : NHtmlUnit.Javascript.Host.UIEvent
   {
      static KeyboardEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.KeyboardEvent o) =>
            new KeyboardEvent(o));
      }

      public KeyboardEvent(com.gargoylesoftware.htmlunit.javascript.host.KeyboardEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.KeyboardEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.KeyboardEvent)WrappedObject; }
      }

      public KeyboardEvent(NHtmlUnit.Html.DomNode domNode, string type, int character, bool shiftKey, bool ctrlKey, bool altKey)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.KeyboardEvent((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject, type, character, shiftKey, ctrlKey, altKey)) {}

      public KeyboardEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.KeyboardEvent()) {}

// Generating method code for jsxFunction_initKeyEvent
      public virtual void JsxFunction_initKeyEvent(string type, bool bubbles, bool cancelable, object view, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, int keyCode, int charCode)
      {
         WObj.jsxFunction_initKeyEvent(type, bubbles, cancelable, view, ctrlKey, altKey, shiftKey, metaKey, keyCode, charCode);
      }

// Generating method code for jsxGet_charCode
      public virtual int JsxGet_charCode()
      {
         return WObj.jsxGet_charCode();
      }

// Generating method code for jsxGet_which
      public virtual object JsxGet_which()
      {
         return WObj.jsxGet_which();
      }

   }


}
