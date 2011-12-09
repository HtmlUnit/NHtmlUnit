// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Node : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Node()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Node o) =>
            new Node(o));
      }

      public Node(com.gargoylesoftware.htmlunit.javascript.host.Node wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Node WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Node)WrappedObject; }
      }

      public Node()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Node()) {}


      public NHtmlUnit.Javascript.Host.Node Parent
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(
               WObj.getParent());
         }
      }

// Generating method code for executeEvent
      public virtual NHtmlUnit.ScriptResult ExecuteEvent(NHtmlUnit.Javascript.Host.Event eventArg)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.executeEvent((com.gargoylesoftware.htmlunit.javascript.host.Event)eventArg.WrappedObject));
      }

// Generating method code for hasEventHandlers
      public virtual bool HasEventHandlers(string eventName)
      {
         return WObj.hasEventHandlers(eventName);
      }

// Generating method code for setEventHandler
      public virtual void SetEventHandler(string eventName, net.sourceforge.htmlunit.corejs.javascript.Function eventHandler)
      {
         WObj.setEventHandler(eventName, eventHandler);
      }

// Generating method code for fireEvent
      public virtual NHtmlUnit.ScriptResult FireEvent(NHtmlUnit.Javascript.Host.Event eventArg)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.fireEvent((com.gargoylesoftware.htmlunit.javascript.host.Event)eventArg.WrappedObject));
      }

// Generating method code for jsxGet_nextSibling
      public virtual NHtmlUnit.Javascript.Host.Node JsxGet_nextSibling()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxGet_nextSibling());
      }

// Generating method code for jsxFunction_replaceChild
      public virtual object JsxFunction_replaceChild(object newChildObject, object oldChildObject)
      {
         return WObj.jsxFunction_replaceChild(newChildObject, oldChildObject);
      }

// Generating method code for jsxFunction_removeChild
      public virtual object JsxFunction_removeChild(object childObject)
      {
         return WObj.jsxFunction_removeChild(childObject);
      }

// Generating method code for jsxFunction_removeEventListener
      public virtual void JsxFunction_removeEventListener(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener, bool useCapture)
      {
         WObj.jsxFunction_removeEventListener(type, listener, useCapture);
      }

// Generating method code for jsxGet_nodeType
      public virtual System.Int16 JsxGet_nodeType()
      {
         return WObj.jsxGet_nodeType();
      }

// Generating method code for jsxGet_nodeName
      public virtual string JsxGet_nodeName()
      {
         return WObj.jsxGet_nodeName();
      }

// Generating method code for jsxGet_nodeValue
      public virtual string JsxGet_nodeValue()
      {
         return WObj.jsxGet_nodeValue();
      }

// Generating method code for jsxSet_nodeValue
      public virtual void JsxSet_nodeValue(string newValue)
      {
         WObj.jsxSet_nodeValue(newValue);
      }

// Generating method code for jsxFunction_appendChild
      public virtual object JsxFunction_appendChild(object childObject)
      {
         return WObj.jsxFunction_appendChild(childObject);
      }

// Generating method code for jsxFunction_cloneNode
      public virtual object JsxFunction_cloneNode(bool deep)
      {
         return WObj.jsxFunction_cloneNode(deep);
      }

// Generating method code for jsxFunction_isSameNode
      public virtual bool JsxFunction_isSameNode(object other)
      {
         return WObj.jsxFunction_isSameNode(other);
      }

// Generating method code for jsxFunction_hasChildNodes
      public virtual bool JsxFunction_hasChildNodes()
      {
         return WObj.jsxFunction_hasChildNodes();
      }

// Generating method code for jsxGet_childNodes
      public virtual IList<NHtmlUnit.W3C.Dom.INode> JsxGet_childNodes()
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.jsxGet_childNodes());
      }

// Generating method code for jsxGet_parentNode
      public virtual object JsxGet_parentNode()
      {
         return WObj.jsxGet_parentNode();
      }

// Generating method code for jsxGet_previousSibling
      public virtual NHtmlUnit.Javascript.Host.Node JsxGet_previousSibling()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxGet_previousSibling());
      }

// Generating method code for jsxGet_firstChild
      public virtual NHtmlUnit.Javascript.Host.Node JsxGet_firstChild()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxGet_firstChild());
      }

// Generating method code for jsxGet_lastChild
      public virtual NHtmlUnit.Javascript.Host.Node JsxGet_lastChild()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxGet_lastChild());
      }

// Generating method code for jsxFunction_attachEvent
      public virtual bool JsxFunction_attachEvent(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener)
      {
         return WObj.jsxFunction_attachEvent(type, listener);
      }

// Generating method code for jsxFunction_addEventListener
      public virtual void JsxFunction_addEventListener(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener, bool useCapture)
      {
         WObj.jsxFunction_addEventListener(type, listener, useCapture);
      }

// Generating method code for jsxFunction_detachEvent
      public virtual void JsxFunction_detachEvent(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener)
      {
         WObj.jsxFunction_detachEvent(type, listener);
      }

// Generating method code for getEventHandler
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetEventHandler(string eventName)
      {
         return WObj.getEventHandler(eventName);
      }

// Generating method code for jsxGet_ownerDocument
      public virtual object JsxGet_ownerDocument()
      {
         return WObj.jsxGet_ownerDocument();
      }

// Generating method code for jsxGet_prefix
      public virtual string JsxGet_prefix()
      {
         return WObj.jsxGet_prefix();
      }

// Generating method code for jsxGet_localName
      public virtual string JsxGet_localName()
      {
         return WObj.jsxGet_localName();
      }

// Generating method code for jsxGet_namespaceURI
      public virtual string JsxGet_namespaceURI()
      {
         return WObj.jsxGet_namespaceURI();
      }

// Generating method code for jsxFunction_compareDocumentPosition
      public virtual System.Int16 JsxFunction_compareDocumentPosition(NHtmlUnit.Javascript.Host.Node node)
      {
         return WObj.jsxFunction_compareDocumentPosition((com.gargoylesoftware.htmlunit.javascript.host.Node)node.WrappedObject);
      }

// Generating method code for jsxFunction_normalize
      public virtual void JsxFunction_normalize()
      {
         WObj.jsxFunction_normalize();
      }

// Generating method code for jsxGet_xml
      public virtual object JsxGet_xml()
      {
         return WObj.jsxGet_xml();
      }

// Generating method code for jsxGet_textContent
      public virtual string JsxGet_textContent()
      {
         return WObj.jsxGet_textContent();
      }

// Generating method code for jsxGet_innerText
      public virtual string JsxGet_innerText()
      {
         return WObj.jsxGet_innerText();
      }

// Generating method code for jsxSet_innerText
      public virtual void JsxSet_innerText(string value)
      {
         WObj.jsxSet_innerText(value);
      }

// Generating method code for jsxSet_textContent
      public virtual void JsxSet_textContent(object value)
      {
         WObj.jsxSet_textContent(value);
      }

   }


}
