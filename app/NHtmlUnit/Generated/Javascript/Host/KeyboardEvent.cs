// Generated class v2.14.0.0, don't modify

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

      public KeyboardEvent(NHtmlUnit.Html.DomNode domNode, string type, System.Char character, bool shiftKey, bool ctrlKey, bool altKey)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.KeyboardEvent((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject, type, character, shiftKey, ctrlKey, altKey)) {}

      public KeyboardEvent(NHtmlUnit.Html.DomNode domNode, string type, int keyCode, bool shiftKey, bool ctrlKey, bool altKey)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.KeyboardEvent((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject, type, keyCode, shiftKey, ctrlKey, altKey)) {}

      public KeyboardEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.KeyboardEvent()) {}


      public System.Int32 CharCode
      {
         get
         {
            return WObj.getCharCode();
         }
      }

      public System.Object Which
      {
         get
         {
            return WObj.getWhich();
         }
      }
// Generating method code for initKeyEvent
      public virtual void InitKeyEvent(string type, bool bubbles, bool cancelable, object view, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, int keyCode, int charCode)
      {
         WObj.initKeyEvent(type, bubbles, cancelable, view, ctrlKey, altKey, shiftKey, metaKey, keyCode, charCode);
      }

   }


}
