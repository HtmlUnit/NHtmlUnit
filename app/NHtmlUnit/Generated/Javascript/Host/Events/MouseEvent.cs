// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MouseEvent : NHtmlUnit.Javascript.Host.Events.UIEvent
   {
      static MouseEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MouseEvent o) =>
            new MouseEvent(o));
      }

      public MouseEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MouseEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MouseEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MouseEvent)WrappedObject; }
      }

      public MouseEvent(NHtmlUnit.Html.DomNode domNode, string type, bool shiftKey, bool ctrlKey, bool altKey, int button)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MouseEvent((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject, type, shiftKey, ctrlKey, altKey, button)) {}

      public MouseEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MouseEvent()) {}


      public System.Int32 ScreenX
      {
         get
         {
            return WObj.getScreenX();
         }
      }

      public System.Int32 ScreenY
      {
         get
         {
            return WObj.getScreenY();
         }
      }

      public System.Int32 ClientX
      {
         get
         {
            return WObj.getClientX();
         }
         set
         {
            WObj.setClientX(value);
         }

      }

      public System.Int32 PageX
      {
         get
         {
            return WObj.getPageX();
         }
      }

      public System.Int32 ClientY
      {
         get
         {
            return WObj.getClientY();
         }
         set
         {
            WObj.setClientY(value);
         }

      }

      public System.Int32 PageY
      {
         get
         {
            return WObj.getPageY();
         }
      }

      public System.Int32 Button
      {
         get
         {
            return WObj.getButton();
         }
         set
         {
            WObj.setButton(value);
         }

      }

      public System.Int32 Which
      {
         get
         {
            return WObj.getWhich();
         }
      }
// Generating method code for initMouseEvent
      public virtual void InitMouseEvent(string type, bool bubbles, bool cancelable, object view, int detail, int screenX, int screenY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, int button, object relatedTarget)
      {
         WObj.initMouseEvent(type, bubbles, cancelable, view, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey, button, relatedTarget);
      }

   }


}
