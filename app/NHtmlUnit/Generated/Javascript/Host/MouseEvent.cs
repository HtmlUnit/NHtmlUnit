// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class MouseEvent : NHtmlUnit.Javascript.Host.UIEvent
   {
      static MouseEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.MouseEvent o) =>
            new MouseEvent(o));
      }

      public MouseEvent(com.gargoylesoftware.htmlunit.javascript.host.MouseEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.MouseEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.MouseEvent)WrappedObject; }
      }

      public MouseEvent(NHtmlUnit.Html.DomNode domNode, string type, bool shiftKey, bool ctrlKey, bool altKey, int button)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.MouseEvent((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject, type, shiftKey, ctrlKey, altKey, button)) {}

      public MouseEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.MouseEvent()) {}

// Generating method code for jsxGet_clientY
      public virtual int JsxGet_clientY()
      {
         return WObj.jsxGet_clientY();
      }

// Generating method code for jsxGet_clientX
      public virtual int JsxGet_clientX()
      {
         return WObj.jsxGet_clientX();
      }

// Generating method code for jsxGet_screenX
      public virtual int JsxGet_screenX()
      {
         return WObj.jsxGet_screenX();
      }

// Generating method code for jsxGet_screenY
      public virtual int JsxGet_screenY()
      {
         return WObj.jsxGet_screenY();
      }

// Generating method code for jsxGet_pageX
      public virtual int JsxGet_pageX()
      {
         return WObj.jsxGet_pageX();
      }

// Generating method code for jsxGet_pageY
      public virtual int JsxGet_pageY()
      {
         return WObj.jsxGet_pageY();
      }

// Generating method code for jsxGet_button
      public virtual int JsxGet_button()
      {
         return WObj.jsxGet_button();
      }

// Generating method code for jsxGet_which
      public virtual int JsxGet_which()
      {
         return WObj.jsxGet_which();
      }

// Generating method code for jsxFunction_initMouseEvent
      public virtual void JsxFunction_initMouseEvent(string type, bool bubbles, bool cancelable, object view, int detail, int screenX, int screenY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, int button, object relatedTarget)
      {
         WObj.jsxFunction_initMouseEvent(type, bubbles, cancelable, view, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey, button, relatedTarget);
      }

   }


}
