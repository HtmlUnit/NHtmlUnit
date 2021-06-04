// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class KeyboardEvent : NHtmlUnit.Javascript.Host.Events.UIEvent
   {
      static KeyboardEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.KeyboardEvent o) =>
            new KeyboardEvent(o));
      }

      public KeyboardEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.KeyboardEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.KeyboardEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.KeyboardEvent)WrappedObject; }
      }

      public KeyboardEvent(NHtmlUnit.Html.DomNode domNode, string type, int keyCode, bool shiftKey, bool ctrlKey, bool altKey)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.KeyboardEvent((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject, type, keyCode, shiftKey, ctrlKey, altKey)) {}

      public KeyboardEvent(NHtmlUnit.Html.DomNode domNode, string type, System.Char character, bool shiftKey, bool ctrlKey, bool altKey)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.KeyboardEvent((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject, type, character, shiftKey, ctrlKey, altKey)) {}

      public KeyboardEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.KeyboardEvent()) {}


      public System.Int32 CharCode
      {
         get
         {
            return WObj.getCharCode();
         }
      }

      public System.Int32 Which
      {
         get
         {
            return WObj.getWhich();
         }
      }

      public System.String Key
      {
         get
         {
            return WObj.getKey();
         }
      }

      public System.String Char
      {
         get
         {
            return WObj.getChar();
         }
      }

      public System.String Code
      {
         get
         {
            return WObj.getCode();
         }
      }

      public System.Boolean MetaKey
      {
         get
         {
            return WObj.getMetaKey();
         }
      }

      public System.Int32 Location
      {
         get
         {
            return WObj.getLocation();
         }
      }

      public System.Boolean IsComposing
      {
         get
         {
            return WObj.getIsComposing();
         }
      }
// Generating method code for initKeyEvent
      public virtual void InitKeyEvent(string type, bool bubbles, bool cancelable, object view, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, int keyCode, int charCode)
      {
         WObj.initKeyEvent(type, bubbles, cancelable, view, ctrlKey, altKey, shiftKey, metaKey, keyCode, charCode);
      }

// Generating method code for isRepeat
      public virtual bool IsRepeat()
      {
         return WObj.isRepeat();
      }

   }


}
