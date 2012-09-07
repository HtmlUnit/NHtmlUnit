// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class EventListenersContainer : ObjectWrapper
   {
      static EventListenersContainer()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.EventListenersContainer o) =>
            new EventListenersContainer(o));
      }

      public EventListenersContainer(com.gargoylesoftware.htmlunit.javascript.host.EventListenersContainer wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.javascript.host.EventListenersContainer WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.EventListenersContainer)WrappedObject; }
      }

// Generating method code for addEventListener
      public virtual bool AddEventListener(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener, bool useCapture)
      {
         return WObj.addEventListener(type, listener, useCapture);
      }

// Generating method code for removeEventListener
      public virtual void RemoveEventListener(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener, bool useCapture)
      {
         WObj.removeEventListener(type, listener, useCapture);
      }

// Generating method code for executeCapturingListeners
      public virtual NHtmlUnit.ScriptResult ExecuteCapturingListeners(NHtmlUnit.Javascript.Host.Event eventArg, System.Object[] args)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.executeCapturingListeners((com.gargoylesoftware.htmlunit.javascript.host.Event)eventArg.WrappedObject, args));
      }

// Generating method code for executeBubblingListeners
      public virtual NHtmlUnit.ScriptResult ExecuteBubblingListeners(NHtmlUnit.Javascript.Host.Event eventArg, System.Object[] args, System.Object[] propHandlerArgs)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.executeBubblingListeners((com.gargoylesoftware.htmlunit.javascript.host.Event)eventArg.WrappedObject, args, propHandlerArgs));
      }

// Generating method code for getEventHandler
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetEventHandler(string eventName)
      {
         return WObj.getEventHandler(eventName);
      }

// Generating method code for hasEventHandlers
      public virtual bool HasEventHandlers(string eventName)
      {
         return WObj.hasEventHandlers(eventName);
      }

// Generating method code for setEventHandlerProp
      public virtual void SetEventHandlerProp(string eventName, object value)
      {
         WObj.setEventHandlerProp(eventName, value);
      }

// Generating method code for getEventHandlerProp
      public virtual object GetEventHandlerProp(string eventName)
      {
         return WObj.getEventHandlerProp(eventName);
      }

// Generating method code for executeListeners
      public virtual NHtmlUnit.ScriptResult ExecuteListeners(NHtmlUnit.Javascript.Host.Event eventArg, System.Object[] args, System.Object[] propHandlerArgs)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.executeListeners((com.gargoylesoftware.htmlunit.javascript.host.Event)eventArg.WrappedObject, args, propHandlerArgs));
      }

   }


}
