// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class Event : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Event()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.Event o) =>
            new Event(o));
      }

      public Event(com.gargoylesoftware.htmlunit.javascript.host.@event.Event wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.Event WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.Event)WrappedObject; }
      }

      public Event(NHtmlUnit.Html.DomNode domNode, string type)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.Event((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject, type)) {}

      public Event(NHtmlUnit.Javascript.Host.Events.EventTarget target, string type)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.Event((com.gargoylesoftware.htmlunit.javascript.host.@event.EventTarget)target.WrappedObject, type)) {}

      public Event()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.Event()) {}


      public System.String Type
      {
         get
         {
            return WObj.getType();
         }
         set
         {
            WObj.setType(value);
         }

      }

      public System.Object SrcElement
      {
         get
         {
            return WObj.getSrcElement();
         }
         set
         {
            WObj.setSrcElement(value);
         }

      }

      public System.Object ReturnValue
      {
         get
         {
            return WObj.getReturnValue();
         }
         set
         {
            WObj.setReturnValue(value);
         }

      }

      public net.sourceforge.htmlunit.corejs.javascript.Scriptable CurrentTarget
      {
         get
         {
            return WObj.getCurrentTarget();
         }
         set
         {
            WObj.setCurrentTarget(value);
         }

      }

      public System.Int64 TimeStamp
      {
         get
         {
            return WObj.getTimeStamp();
         }
      }

      public System.Int32 KeyCode
      {
         get
         {
            return WObj.getKeyCode();
         }
      }

      public System.String PropertyName
      {
         get
         {
            return WObj.getPropertyName();
         }
      }

      public System.Object Composed
      {
         get
         {
            return WObj.getComposed();
         }
      }
// Generating method code for isAborted
      public virtual bool IsAborted(NHtmlUnit.ScriptResult result)
      {
         return WObj.isAborted((com.gargoylesoftware.htmlunit.ScriptResult)result.WrappedObject);
      }

// Generating method code for isShiftKey
      public virtual bool IsShiftKey()
      {
         return WObj.isShiftKey();
      }

// Generating method code for isCtrlKey
      public virtual bool IsCtrlKey()
      {
         return WObj.isCtrlKey();
      }

// Generating method code for startFire
      public virtual void StartFire()
      {
         WObj.startFire();
      }

// Generating method code for isPropagationStopped
      public virtual bool IsPropagationStopped()
      {
         return WObj.isPropagationStopped();
      }

// Generating method code for endFire
      public virtual void EndFire()
      {
         WObj.endFire();
      }

// Generating method code for isBubbles
      public virtual bool IsBubbles()
      {
         return WObj.isBubbles();
      }

// Generating method code for processLabelAfterBubbling
      public virtual bool ProcessLabelAfterBubbling()
      {
         return WObj.processLabelAfterBubbling();
      }

// Generating method code for isAltKey
      public virtual bool IsAltKey()
      {
         return WObj.isAltKey();
      }

// Generating method code for initEvent
      public virtual void InitEvent(string type, bool bubbles, bool cancelable)
      {
         WObj.initEvent(type, bubbles, cancelable);
      }

// Generating method code for stopPropagation
      public virtual void StopPropagation()
      {
         WObj.stopPropagation();
      }

// Generating method code for preventDefault
      public virtual void PreventDefault()
      {
         WObj.preventDefault();
      }

// Generating method code for isCancelable
      public virtual bool IsCancelable()
      {
         return WObj.isCancelable();
      }

// Generating method code for eventCreated
      public virtual void EventCreated()
      {
         WObj.eventCreated();
      }

// Generating method code for jsConstructor
      public virtual void JsConstructor(string type, net.sourceforge.htmlunit.corejs.javascript.ScriptableObject details)
      {
         WObj.jsConstructor(type, details);
      }

// Generating method code for isDefaultPrevented
      public virtual bool IsDefaultPrevented()
      {
         return WObj.isDefaultPrevented();
      }

// Generating method code for isCancelBubble
      public virtual bool IsCancelBubble()
      {
         return WObj.isCancelBubble();
      }

// Generating method code for stopImmediatePropagation
      public virtual void StopImmediatePropagation()
      {
         WObj.stopImmediatePropagation();
      }

// Generating method code for isImmediatePropagationStopped
      public virtual bool IsImmediatePropagationStopped()
      {
         return WObj.isImmediatePropagationStopped();
      }

// Generating method code for getEventPhase
      public virtual int GetEventPhase()
      {
         return WObj.getEventPhase();
      }

// Generating method code for setEventPhase
      public virtual void SetEventPhase(System.Int16 phase)
      {
         WObj.setEventPhase(phase);
      }

// Generating method code for getTarget
      public virtual object GetTarget()
      {
         var arg = WObj.getTarget();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for setTarget
      public virtual void SetTarget(NHtmlUnit.Javascript.Host.Events.EventTarget target)
      {
         WObj.setTarget((com.gargoylesoftware.htmlunit.javascript.host.@event.EventTarget)target.WrappedObject);
      }

   }


}
