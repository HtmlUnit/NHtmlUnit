// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class PointerEvent : NHtmlUnit.Javascript.Host.Events.MouseEvent
   {
      static PointerEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.PointerEvent o) =>
            new PointerEvent(o));
      }

      public PointerEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.PointerEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.PointerEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.PointerEvent)WrappedObject; }
      }

      public PointerEvent(NHtmlUnit.Html.DomNode domNode, string type, bool shiftKey, bool ctrlKey, bool altKey, int button)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.PointerEvent((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject, type, shiftKey, ctrlKey, altKey, button)) {}

      public PointerEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.PointerEvent()) {}


      public System.Int64 PointerId
      {
         get
         {
            return WObj.getPointerId();
         }
      }

      public System.Int64 Width
      {
         get
         {
            return WObj.getWidth();
         }
      }

      public System.Int64 Height
      {
         get
         {
            return WObj.getHeight();
         }
      }

      public System.Double Pressure
      {
         get
         {
            return WObj.getPressure();
         }
      }

      public System.Int64 TiltX
      {
         get
         {
            return WObj.getTiltX();
         }
      }

      public System.Int64 TiltY
      {
         get
         {
            return WObj.getTiltY();
         }
      }

      public System.String PointerType
      {
         get
         {
            return WObj.getPointerType();
         }
      }
// Generating method code for initPointerEvent
      public virtual void InitPointerEvent(string type, bool bubbles, bool cancelable, object view, int detail, int screenX, int screenY, int clientX, int clientY, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, int button, object relatedTarget, int offsetX, int offsetY, int width, int height, java.lang.Double pressure, int rotation, int tiltX, int tiltY, int pointerId, string pointerType, int hwTimestamp, bool isPrimary)
      {
         WObj.initPointerEvent(type, bubbles, cancelable, view, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey, button, relatedTarget, offsetX, offsetY, width, height, pressure, rotation, tiltX, tiltY, pointerId, pointerType, hwTimestamp, isPrimary);
      }

// Generating method code for isPrimary
      public virtual bool IsPrimary()
      {
         return WObj.isPrimary();
      }

   }


}
