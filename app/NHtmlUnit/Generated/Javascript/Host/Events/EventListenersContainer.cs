// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class EventListenersContainer : ObjectWrapper
   {
      static EventListenersContainer()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.EventListenersContainer o) =>
            new EventListenersContainer(o));
      }

      public EventListenersContainer(com.gargoylesoftware.htmlunit.javascript.host.@event.EventListenersContainer wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.javascript.host.@event.EventListenersContainer WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.EventListenersContainer)WrappedObject; }
      }

      public EventListenersContainer(NHtmlUnit.Javascript.Host.Events.EventTarget jsNode)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.EventListenersContainer((com.gargoylesoftware.htmlunit.javascript.host.@event.EventTarget)jsNode.WrappedObject)) {}

// Generating method code for addEventListener
      public virtual bool AddEventListener(string type, net.sourceforge.htmlunit.corejs.javascript.Scriptable listener, bool useCapture)
      {
         return WObj.addEventListener(type, listener, useCapture);
      }

// Generating method code for executeListeners
      public virtual NHtmlUnit.ScriptResult ExecuteListeners(NHtmlUnit.Javascript.Host.Events.Event eventArg, System.Object[] args, System.Object[] propHandlerArgs)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.executeListeners((com.gargoylesoftware.htmlunit.javascript.host.@event.Event)eventArg.WrappedObject, args, propHandlerArgs));
      }

// Generating method code for executeCapturingListeners
      public virtual NHtmlUnit.ScriptResult ExecuteCapturingListeners(NHtmlUnit.Javascript.Host.Events.Event eventArg, System.Object[] args)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.executeCapturingListeners((com.gargoylesoftware.htmlunit.javascript.host.@event.Event)eventArg.WrappedObject, args));
      }

// Generating method code for executeBubblingListeners
      public virtual NHtmlUnit.ScriptResult ExecuteBubblingListeners(NHtmlUnit.Javascript.Host.Events.Event eventArg, System.Object[] args, System.Object[] propHandlerArgs)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.executeBubblingListeners((com.gargoylesoftware.htmlunit.javascript.host.@event.Event)eventArg.WrappedObject, args, propHandlerArgs));
      }

// Generating method code for hasEventHandlers
      public virtual bool HasEventHandlers(string eventName)
      {
         return WObj.hasEventHandlers(eventName);
      }

// Generating method code for getEventHandler
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetEventHandler(string eventName)
      {
         return WObj.getEventHandler(eventName);
      }

// Generating method code for getEventHandlerProp
      public virtual object GetEventHandlerProp(string eventName)
      {
         return WObj.getEventHandlerProp(eventName);
      }

// Generating method code for removeEventListener
      public virtual void RemoveEventListener(string type, net.sourceforge.htmlunit.corejs.javascript.Scriptable listener, bool useCapture)
      {
         WObj.removeEventListener(type, listener, useCapture);
      }

// Generating method code for setEventHandlerProp
      public virtual void SetEventHandlerProp(string eventName, object value)
      {
         WObj.setEventHandlerProp(eventName, value);
      }

// Generating method code for copyFrom
      public virtual void CopyFrom(NHtmlUnit.Javascript.Host.Events.EventListenersContainer eventListenersContainer)
      {
         WObj.copyFrom((com.gargoylesoftware.htmlunit.javascript.host.@event.EventListenersContainer)eventListenersContainer.WrappedObject);
      }

// Generating method code for getHandlers
      public virtual IList<net.sourceforge.htmlunit.corejs.javascript.Scriptable> GetHandlers(string eventType, bool useCapture)
      {

         return new ShallowListWrapper<net.sourceforge.htmlunit.corejs.javascript.Scriptable>(WObj.getHandlers(eventType, useCapture));
      }

   }


}
