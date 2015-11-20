// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class EventTarget : NHtmlUnit.Javascript.SimpleScriptable
   {
      static EventTarget()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.EventTarget o) =>
            new EventTarget(o));
      }

      public EventTarget(com.gargoylesoftware.htmlunit.javascript.host.@event.EventTarget wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.EventTarget WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.EventTarget)WrappedObject; }
      }

      public EventTarget()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.EventTarget()) {}


      public NHtmlUnit.Javascript.Host.Events.EventListenersContainer EventListenersContainer
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Events.EventListenersContainer>(
               WObj.getEventListenersContainer());
         }
      }

// Generating method code for hasEventHandlers
      public virtual bool HasEventHandlers(string eventName)
      {
         return WObj.hasEventHandlers(eventName);
      }

// Generating method code for executeEventLocally
      public virtual NHtmlUnit.ScriptResult ExecuteEventLocally(NHtmlUnit.Javascript.Host.Events.Event eventArg)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.executeEventLocally((com.gargoylesoftware.htmlunit.javascript.host.@event.Event)eventArg.WrappedObject));
      }

// Generating method code for setEventHandler
      public virtual void SetEventHandler(string eventName, net.sourceforge.htmlunit.corejs.javascript.Function eventHandler)
      {
         WObj.setEventHandler(eventName, eventHandler);
      }

// Generating method code for fireEvent
      public virtual NHtmlUnit.ScriptResult FireEvent(NHtmlUnit.Javascript.Host.Events.Event eventArg)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.fireEvent((com.gargoylesoftware.htmlunit.javascript.host.@event.Event)eventArg.WrappedObject));
      }

// Generating method code for addEventListener
      public virtual void AddEventListener(string type, net.sourceforge.htmlunit.corejs.javascript.Scriptable listener, bool useCapture)
      {
         WObj.addEventListener(type, listener, useCapture);
      }

// Generating method code for getEventHandler
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetEventHandler(string eventName)
      {
         return WObj.getEventHandler(eventName);
      }

// Generating method code for dispatchEvent
      public virtual bool DispatchEvent(NHtmlUnit.Javascript.Host.Events.Event eventArg)
      {
         return WObj.dispatchEvent((com.gargoylesoftware.htmlunit.javascript.host.@event.Event)eventArg.WrappedObject);
      }

// Generating method code for removeEventListener
      public virtual void RemoveEventListener(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener, bool useCapture)
      {
         WObj.removeEventListener(type, listener, useCapture);
      }

   }


}
