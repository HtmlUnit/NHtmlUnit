// Generated class v2.13, don't modify

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


      public NHtmlUnit.Javascript.Host.Node NextSibling
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(
               WObj.getNextSibling());
         }
      }


      public NHtmlUnit.Javascript.Host.Node Parent
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(
               WObj.getParent());
         }
      }


      public NHtmlUnit.Javascript.Host.Element ParentElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Element>(
               WObj.getParentElement());
         }
      }


      public System.Int16 NodeType
      {
         get
         {
            return WObj.getNodeType();
         }
      }

      public System.String NodeName
      {
         get
         {
            return WObj.getNodeName();
         }
      }

      public System.String NodeValue
      {
         get
         {
            return WObj.getNodeValue();
         }
         set
         {
            WObj.setNodeValue(value);
         }

      }

      public IList<NHtmlUnit.W3C.Dom.INode> ChildNodes
      {
         get
         {
            return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(
               WObj.getChildNodes());
         }
       }

      public System.Object ParentNode
      {
         get
         {
            return WObj.getParentNode();
         }
      }

      public NHtmlUnit.Javascript.Host.Node PreviousSibling
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(
               WObj.getPreviousSibling());
         }
      }


      public NHtmlUnit.Javascript.Host.Node FirstChild
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(
               WObj.getFirstChild());
         }
      }


      public NHtmlUnit.Javascript.Host.Node LastChild
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(
               WObj.getLastChild());
         }
      }


      public System.Object OwnerDocument
      {
         get
         {
            return WObj.getOwnerDocument();
         }
      }

      public System.String Prefix
      {
         get
         {
            return WObj.getPrefix();
         }
      }

      public System.String LocalName
      {
         get
         {
            return WObj.getLocalName();
         }
      }

      public System.String NamespaceURI
      {
         get
         {
            return WObj.getNamespaceURI();
         }
      }

      public System.Object BaseName
      {
         get
         {
            return WObj.getBaseName();
         }
      }

      public System.Object Xml
      {
         get
         {
            return WObj.getXml();
         }
      }

      public System.Object Attributes
      {
         get
         {
            return WObj.getAttributes();
         }
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

// Generating method code for executeEvent
      public virtual NHtmlUnit.ScriptResult ExecuteEvent(NHtmlUnit.Javascript.Host.Event eventArg)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.executeEvent((com.gargoylesoftware.htmlunit.javascript.host.Event)eventArg.WrappedObject));
      }

// Generating method code for replaceChild
      public virtual object ReplaceChild(object newChildObject, object oldChildObject)
      {
         return WObj.replaceChild(newChildObject, oldChildObject);
      }

// Generating method code for removeChild
      public virtual object RemoveChild(object childObject)
      {
         return WObj.removeChild(childObject);
      }

// Generating method code for removeEventListener
      public virtual void RemoveEventListener(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener, bool useCapture)
      {
         WObj.removeEventListener(type, listener, useCapture);
      }

// Generating method code for appendChild
      public virtual object AppendChild(object childObject)
      {
         return WObj.appendChild(childObject);
      }

// Generating method code for cloneNode
      public virtual object CloneNode(bool deep)
      {
         return WObj.cloneNode(deep);
      }

// Generating method code for isSameNode
      public virtual bool IsSameNode(object other)
      {
         return WObj.isSameNode(other);
      }

// Generating method code for hasChildNodes
      public virtual bool HasChildNodes()
      {
         return WObj.hasChildNodes();
      }

// Generating method code for attachEvent
      public virtual bool AttachEvent(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener)
      {
         return WObj.attachEvent(type, listener);
      }

// Generating method code for addEventListener
      public virtual void AddEventListener(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener, bool useCapture)
      {
         WObj.addEventListener(type, listener, useCapture);
      }

// Generating method code for detachEvent
      public virtual void DetachEvent(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener)
      {
         WObj.detachEvent(type, listener);
      }

// Generating method code for getEventHandler
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetEventHandler(string eventName)
      {
         return WObj.getEventHandler(eventName);
      }

// Generating method code for compareDocumentPosition
      public virtual System.Int16 CompareDocumentPosition(object node)
      {
         return WObj.compareDocumentPosition(node);
      }

// Generating method code for normalize
      public virtual void Normalize()
      {
         WObj.normalize();
      }

// Generating method code for contains
      public virtual bool Contains(object element)
      {
         return WObj.contains(element);
      }

// Generating method code for getTextContent
      public virtual string GetTextContent()
      {
         return WObj.getTextContent();
      }

// Generating method code for setTextContent
      public virtual void SetTextContent(object value)
      {
         WObj.setTextContent(value);
      }

   }


}
