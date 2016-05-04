// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class XMLDOMNode : NHtmlUnit.Activex.Javascript.Msxml.MSXMLScriptable
   {
      static XMLDOMNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNode o) =>
            new XMLDOMNode(o));
      }

      public XMLDOMNode(com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNode)WrappedObject; }
      }

      public XMLDOMNode()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNode()) {}


      public System.Object OwnerDocument
      {
         get
         {
            return WObj.getOwnerDocument();
         }
      }

      public NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode NextSibling
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode>(
               WObj.getNextSibling());
         }
      }


      public System.Object Attributes
      {
         get
         {
            return WObj.getAttributes();
         }
      }

      public System.String BaseName
      {
         get
         {
            return WObj.getBaseName();
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

      public System.String DataType
      {
         get
         {
            return WObj.getDataType();
         }
      }

      public System.String Definition
      {
         get
         {
            return WObj.getDefinition();
         }
      }

      public NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode FirstChild
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode>(
               WObj.getFirstChild());
         }
      }


      public NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode LastChild
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode>(
               WObj.getLastChild());
         }
      }


      public System.String NamespaceURI
      {
         get
         {
            return WObj.getNamespaceURI();
         }
      }

      public System.String NodeName
      {
         get
         {
            return WObj.getNodeName();
         }
      }

      public System.Int16 NodeType
      {
         get
         {
            return WObj.getNodeType();
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

      public System.Object ParentNode
      {
         get
         {
            return WObj.getParentNode();
         }
      }

      public System.String Prefix
      {
         get
         {
            return WObj.getPrefix();
         }
      }

      public NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode PreviousSibling
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode>(
               WObj.getPreviousSibling());
         }
      }


      public System.Object Text
      {
         get
         {
            return WObj.getText();
         }
         set
         {
            WObj.setText(value);
         }

      }

      public System.Object Xml
      {
         get
         {
            return WObj.getXml();
         }
      }
// Generating method code for replaceChild
      public virtual object ReplaceChild(object newChild, object oldChild)
      {
         var arg = WObj.replaceChild(newChild, oldChild);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for removeChild
      public virtual object RemoveChild(object childNode)
      {
         var arg = WObj.removeChild(childNode);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for selectNodes
      public virtual IList<NHtmlUnit.W3C.Dom.INode> SelectNodes(string expression)
      {

return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.selectNodes(expression));
      }

// Generating method code for appendChild
      public virtual object AppendChild(object newChild)
      {
         var arg = WObj.appendChild(newChild);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for cloneNode
      public virtual object CloneNode(bool deep)
      {
         var arg = WObj.cloneNode(deep);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for hasChildNodes
      public virtual bool HasChildNodes()
      {
         return WObj.hasChildNodes();
      }

// Generating method code for selectSingleNode
      public virtual object SelectSingleNode(string expression)
      {
         var arg = WObj.selectSingleNode(expression);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

   }


}
