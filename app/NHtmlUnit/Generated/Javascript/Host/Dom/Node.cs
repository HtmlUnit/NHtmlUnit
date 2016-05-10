// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class Node : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static Node()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.Node o) =>
            new Node(o));
      }

      public Node(com.gargoylesoftware.htmlunit.javascript.host.dom.Node wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.Node WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.Node)WrappedObject; }
      }

      public Node()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.Node()) {}


      public NHtmlUnit.Javascript.Host.Element ParentElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Element>(
               WObj.getParentElement());
         }
      }


      public NHtmlUnit.Javascript.Host.Dom.Node FirstChild
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(
               WObj.getFirstChild());
         }
      }


      public NHtmlUnit.Javascript.Host.Dom.Node NextSibling
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(
               WObj.getNextSibling());
         }
      }


      public NHtmlUnit.Javascript.Host.Dom.Node Parent
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(
               WObj.getParent());
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

      public NHtmlUnit.Javascript.Host.Dom.NodeList ChildNodes
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.NodeList>(
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

      public NHtmlUnit.Javascript.Host.Dom.Node PreviousSibling
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(
               WObj.getPreviousSibling());
         }
      }


      public NHtmlUnit.Javascript.Host.Dom.Node LastChild
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(
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

      public System.Object Prefix
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
// Generating method code for replaceChild
      public virtual object ReplaceChild(object newChildObject, object oldChildObject)
      {
         var arg = WObj.replaceChild(newChildObject, oldChildObject);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for removeChild
      public virtual object RemoveChild(object childObject)
      {
         var arg = WObj.removeChild(childObject);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for appendChild
      public virtual object AppendChild(object childObject)
      {
         var arg = WObj.appendChild(childObject);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for cloneNode
      public virtual object CloneNode(bool deep)
      {
         var arg = WObj.cloneNode(deep);
         return ObjectWrapper.CreateWrapper<object>(arg);
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

// Generating method code for detachEvent
      public virtual void DetachEvent(string type, net.sourceforge.htmlunit.corejs.javascript.Function listener)
      {
         WObj.detachEvent(type, listener);
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
