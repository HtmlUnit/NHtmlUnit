// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Event : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Event()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Event o) =>
            new Event(o));
      }

      public Event(com.gargoylesoftware.htmlunit.javascript.host.Event wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Event WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Event)WrappedObject; }
      }

      public Event(NHtmlUnit.Html.DomNode domNode, string type)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Event((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject, type)) {}

      public Event()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Event()) {}

// Generating method code for isAborted
      public virtual bool IsAborted(NHtmlUnit.ScriptResult result)
      {
         return WObj.isAborted((com.gargoylesoftware.htmlunit.ScriptResult)result.WrappedObject);
      }

// Generating method code for jsxGet_type
      public virtual string JsxGet_type()
      {
         return WObj.jsxGet_type();
      }

// Generating method code for jsxGet_returnValue
      public virtual object JsxGet_returnValue()
      {
         return WObj.jsxGet_returnValue();
      }

// Generating method code for jsxGet_srcElement
      public virtual object JsxGet_srcElement()
      {
         return WObj.jsxGet_srcElement();
      }

// Generating method code for jsxSet_srcElement
      public virtual void JsxSet_srcElement(object srcElement)
      {
         WObj.jsxSet_srcElement(srcElement);
      }

// Generating method code for jsxGet_target
      public virtual object JsxGet_target()
      {
         return WObj.jsxGet_target();
      }

// Generating method code for jsxGet_currentTarget
      public virtual object JsxGet_currentTarget()
      {
         return WObj.jsxGet_currentTarget();
      }

// Generating method code for jsxGet_timeStamp
      public virtual System.Int64 JsxGet_timeStamp()
      {
         return WObj.jsxGet_timeStamp();
      }

// Generating method code for jsxGet_keyCode
      public virtual object JsxGet_keyCode()
      {
         return WObj.jsxGet_keyCode();
      }

// Generating method code for jsxGet_shiftKey
      public virtual bool JsxGet_shiftKey()
      {
         return WObj.jsxGet_shiftKey();
      }

// Generating method code for jsxGet_ctrlKey
      public virtual bool JsxGet_ctrlKey()
      {
         return WObj.jsxGet_ctrlKey();
      }

// Generating method code for jsxGet_altKey
      public virtual bool JsxGet_altKey()
      {
         return WObj.jsxGet_altKey();
      }

// Generating method code for jsxGet_eventPhase
      public virtual int JsxGet_eventPhase()
      {
         return WObj.jsxGet_eventPhase();
      }

// Generating method code for jsxGet_bubbles
      public virtual bool JsxGet_bubbles()
      {
         return WObj.jsxGet_bubbles();
      }

// Generating method code for jsxGet_cancelable
      public virtual bool JsxGet_cancelable()
      {
         return WObj.jsxGet_cancelable();
      }

// Generating method code for jsxGet_cancelBubble
      public virtual bool JsxGet_cancelBubble()
      {
         return WObj.jsxGet_cancelBubble();
      }

// Generating method code for jsxSet_cancelBubble
      public virtual void JsxSet_cancelBubble(bool newValue)
      {
         WObj.jsxSet_cancelBubble(newValue);
      }

// Generating method code for jsxFunction_stopPropagation
      public virtual void JsxFunction_stopPropagation()
      {
         WObj.jsxFunction_stopPropagation();
      }

// Generating method code for isPropagationStopped
      public virtual bool IsPropagationStopped()
      {
         return WObj.isPropagationStopped();
      }

// Generating method code for jsxGet_propertyName
      public virtual string JsxGet_propertyName()
      {
         return WObj.jsxGet_propertyName();
      }

// Generating method code for jsxSet_returnValue
      public virtual void JsxSet_returnValue(object returnValue)
      {
         WObj.jsxSet_returnValue(returnValue);
      }

// Generating method code for jsxFunction_initEvent
      public virtual void JsxFunction_initEvent(string type, bool bubbles, bool cancelable)
      {
         WObj.jsxFunction_initEvent(type, bubbles, cancelable);
      }

// Generating method code for jsxFunction_preventDefault
      public virtual void JsxFunction_preventDefault()
      {
         WObj.jsxFunction_preventDefault();
      }

// Generating method code for applies
      public virtual bool Applies(NHtmlUnit.Html.DomNode node)
      {
         return WObj.applies((com.gargoylesoftware.htmlunit.html.DomNode)node.WrappedObject);
      }

   }


}
