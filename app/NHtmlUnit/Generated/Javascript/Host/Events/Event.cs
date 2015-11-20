// Generated class v2.19.0.0, don't modify

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

      public Event(NHtmlUnit.Javascript.SimpleScriptable scriptable, string type)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.Event((com.gargoylesoftware.htmlunit.javascript.SimpleScriptable)scriptable.WrappedObject, type)) {}

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

      public System.Object Target
      {
         get
         {
            return WObj.getTarget();
         }
         set
         {
            WObj.setTarget(value);
         }

      }

      public System.Boolean CancelBubble
      {
         get
         {
            return WObj.getCancelBubble();
         }
         set
         {
            WObj.setCancelBubble(value);
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

      public System.Object KeyCode
      {
         get
         {
            return WObj.getKeyCode();
         }
      }

      public System.Boolean ShiftKey
      {
         get
         {
            return WObj.getShiftKey();
         }
      }

      public System.Boolean CtrlKey
      {
         get
         {
            return WObj.getCtrlKey();
         }
      }

      public System.Boolean AltKey
      {
         get
         {
            return WObj.getAltKey();
         }
      }

      public System.Boolean Bubbles
      {
         get
         {
            return WObj.getBubbles();
         }
      }

      public System.Boolean Cancelable
      {
         get
         {
            return WObj.getCancelable();
         }
      }

      public System.Boolean DefaultPrevented
      {
         get
         {
            return WObj.getDefaultPrevented();
         }
      }

      public System.String PropertyName
      {
         get
         {
            return WObj.getPropertyName();
         }
      }
// Generating method code for isAborted
      public virtual bool IsAborted(NHtmlUnit.ScriptResult result)
      {
         return WObj.isAborted((com.gargoylesoftware.htmlunit.ScriptResult)result.WrappedObject);
      }

// Generating method code for applies
      public virtual bool Applies(NHtmlUnit.Html.DomNode node)
      {
         return WObj.applies((com.gargoylesoftware.htmlunit.html.DomNode)node.WrappedObject);
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

// Generating method code for initEvent
      public virtual void InitEvent(string type, bool bubbles, bool cancelable)
      {
         WObj.initEvent(type, bubbles, cancelable);
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

   }


}
