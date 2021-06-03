// Generated class v2.50.0.0, don't modify

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

// Generating method code for executeAtTargetListeners
      public virtual void ExecuteAtTargetListeners(NHtmlUnit.Javascript.Host.Events.Event eventArg, System.Object[] args)
      {
         WObj.executeAtTargetListeners((com.gargoylesoftware.htmlunit.javascript.host.@event.Event)eventArg.WrappedObject, args);
      }

// Generating method code for executeCapturingListeners
      public virtual void ExecuteCapturingListeners(NHtmlUnit.Javascript.Host.Events.Event eventArg, System.Object[] args)
      {
         WObj.executeCapturingListeners((com.gargoylesoftware.htmlunit.javascript.host.@event.Event)eventArg.WrappedObject, args);
      }

// Generating method code for executeBubblingListeners
      public virtual void ExecuteBubblingListeners(NHtmlUnit.Javascript.Host.Events.Event eventArg, System.Object[] args)
      {
         WObj.executeBubblingListeners((com.gargoylesoftware.htmlunit.javascript.host.@event.Event)eventArg.WrappedObject, args);
      }

// Generating method code for getEventHandler
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetEventHandler(string eventType)
      {
         return WObj.getEventHandler(eventType);
      }

// Generating method code for setEventHandler
      public virtual void SetEventHandler(string eventType, object value)
      {
         WObj.setEventHandler(eventType, value);
      }

// Generating method code for getListeners
      public virtual IList<net.sourceforge.htmlunit.corejs.javascript.Scriptable> GetListeners(string eventType, bool useCapture)
      {

return new ShallowListWrapper<net.sourceforge.htmlunit.corejs.javascript.Scriptable>(WObj.getListeners(eventType, useCapture));
      }

   }


}
