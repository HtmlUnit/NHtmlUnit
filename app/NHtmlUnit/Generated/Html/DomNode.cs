// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class DomNode : ObjectWrapper, NHtmlUnit.W3C.Dom.INode
   {
      static DomNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.DomNode o) =>
            new DomNode(o));
      }

      public DomNode(com.gargoylesoftware.htmlunit.html.DomNode wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.html.DomNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.DomNode)WrappedObject; }
      }


      public net.sourceforge.htmlunit.corejs.javascript.ScriptableObject ScriptObject
      {
         get
         {
            return WObj.getScriptObject();
         }
         set
         {
            WObj.setScriptObject(value);
         }

      }

      public System.String NodeName
      {
         get
         {
            return WObj.getNodeName();
         }
      }

      public NHtmlUnit.SgmlPage Page
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.SgmlPage>(
               WObj.getPage());
         }
      }


      public System.String LocalName
      {
         get
         {
            return WObj.getLocalName();
         }
      }

      public NHtmlUnit.W3C.Dom.IDocument OwnerDocument
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IDocument>(
               WObj.getOwnerDocument());
         }
      }


      public NHtmlUnit.Html.DomNode ParentNode
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(
               WObj.getParentNode());
         }
      }


      public NHtmlUnit.Html.DomNode FirstChild
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(
               WObj.getFirstChild());
         }
      }


      public NHtmlUnit.Html.DomNode LastChild
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(
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

      public NHtmlUnit.Html.DomNode NextSibling
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(
               WObj.getNextSibling());
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

      public System.String Prefix
      {
         get
         {
            return WObj.getPrefix();
         }
         set
         {
            WObj.setPrefix(value);
         }

      }

      public NHtmlUnit.Html.HtmlPage HtmlPageOrNull
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlPage>(
               WObj.getHtmlPageOrNull());
         }
      }


      public NHtmlUnit.Html.DomNode PreviousSibling
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(
               WObj.getPreviousSibling());
         }
      }


      public System.String TextContent
      {
         get
         {
            return WObj.getTextContent();
         }
         set
         {
            WObj.setTextContent(value);
         }

      }

      public IEnumerable<NHtmlUnit.Html.DomNode> Children
      {
         get
         {
            return new IterableWrapper<NHtmlUnit.Html.DomNode>(
               WObj.getChildren());
         }
       }

      public IEnumerable<NHtmlUnit.Html.DomNode> Descendants
      {
         get
         {
            return new IterableWrapper<NHtmlUnit.Html.DomNode>(
               WObj.getDescendants());
         }
       }

      public NHtmlUnit.W3C.Dom.INamedNodeMap Attributes
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.INamedNodeMap>(
               WObj.getAttributes());
         }
      }


      public System.String ReadyState
      {
         get
         {
            return WObj.getReadyState();
         }
         set
         {
            WObj.setReadyState(value);
         }

      }

      public System.Int32 StartLineNumber
      {
         get
         {
            return WObj.getStartLineNumber();
         }
      }

      public System.Int32 EndLineNumber
      {
         get
         {
            return WObj.getEndLineNumber();
         }
      }

      public IEnumerable<NHtmlUnit.Html.HtmlElement> HtmlElementDescendants
      {
         get
         {
            return new IterableWrapper<NHtmlUnit.Html.HtmlElement>(
               WObj.getHtmlElementDescendants());
         }
       }

      public IList<NHtmlUnit.W3C.Dom.INode> ChildNodes
      {
         get
         {
            return new ListWrapper<NHtmlUnit.W3C.Dom.INode>(
               WObj.getChildNodes());
         }
       }

      public System.Int32 StartColumnNumber
      {
         get
         {
            return WObj.getStartColumnNumber();
         }
      }

      public System.Int32 EndColumnNumber
      {
         get
         {
            return WObj.getEndColumnNumber();
         }
      }

      public System.Int32 Index
      {
         get
         {
            return WObj.getIndex();
         }
      }

      public System.String BaseURI
      {
         get
         {
            return WObj.getBaseURI();
         }
      }

      public System.String CanonicalXPath
      {
         get
         {
            return WObj.getCanonicalXPath();
         }
      }
// Generating method code for asXml
      public virtual string AsXml()
      {
         return WObj.asXml();
      }

// Generating method code for appendChild
      public virtual NHtmlUnit.Html.DomNode AppendChild(NHtmlUnit.W3C.Dom.INode node)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(WObj.appendChild((org.w3c.dom.Node)node.WrappedObject));
      }

// Generating method code for cloneNode
      public virtual NHtmlUnit.Html.DomNode CloneNode(bool deep)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(WObj.cloneNode(deep));
      }

// Generating method code for insertBefore
      public virtual void InsertBefore(NHtmlUnit.Html.DomNode newNode)
      {
         WObj.insertBefore((com.gargoylesoftware.htmlunit.html.DomNode)newNode.WrappedObject);
      }

// Generating method code for remove
      public virtual void Remove()
      {
         WObj.remove();
      }

// Generating method code for replace
      public virtual void Replace(NHtmlUnit.Html.DomNode newNode)
      {
         WObj.replace((com.gargoylesoftware.htmlunit.html.DomNode)newNode.WrappedObject);
      }

// Generating method code for removeChild
      public virtual NHtmlUnit.W3C.Dom.INode RemoveChild(NHtmlUnit.W3C.Dom.INode child)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.removeChild((org.w3c.dom.Node)child.WrappedObject));
      }

// Generating method code for addDomChangeListener
      public virtual void AddDomChangeListener(NHtmlUnit.Html.IDomChangeListener listener)
      {
         WObj.addDomChangeListener((com.gargoylesoftware.htmlunit.html.DomChangeListener)listener.WrappedObject);
      }

// Generating method code for normalize
      public virtual void Normalize()
      {
         WObj.normalize();
      }

// Generating method code for getByXPath
      public virtual IList<System.Object> GetByXPath(string xpathExpr)
      {

         return new ShallowListWrapper<System.Object>(WObj.getByXPath(xpathExpr));
      }

// Generating method code for isAncestorOf
      public virtual bool IsAncestorOf(NHtmlUnit.Html.DomNode node)
      {
         return WObj.isAncestorOf((com.gargoylesoftware.htmlunit.html.DomNode)node.WrappedObject);
      }

// Generating method code for insertBefore
      public virtual NHtmlUnit.W3C.Dom.INode InsertBefore(NHtmlUnit.W3C.Dom.INode newChild, NHtmlUnit.W3C.Dom.INode refChild)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.insertBefore((org.w3c.dom.Node)newChild.WrappedObject, (org.w3c.dom.Node)refChild.WrappedObject));
      }

// Generating method code for removeAllChildren
      public virtual void RemoveAllChildren()
      {
         WObj.removeAllChildren();
      }

// Generating method code for mayBeDisplayed
      public virtual bool MayBeDisplayed()
      {
         return WObj.mayBeDisplayed();
      }

// Generating method code for isDirectlyAttachedToPage
      public virtual bool IsDirectlyAttachedToPage()
      {
         return WObj.isDirectlyAttachedToPage();
      }

// Generating method code for getFirstByXPath
      public virtual object GetFirstByXPath(string xpathExpr, org.apache.xml.utils.PrefixResolver resolver)
      {
         return WObj.getFirstByXPath(xpathExpr, resolver);
      }

// Generating method code for getByXPath
      public virtual IList<System.Object> GetByXPath(string xpathExpr, org.apache.xml.utils.PrefixResolver resolver)
      {

         return new ShallowListWrapper<System.Object>(WObj.getByXPath(xpathExpr, resolver));
      }

// Generating method code for querySelectorAll
      public virtual IList<NHtmlUnit.W3C.Dom.INode> QuerySelectorAll(string selectors)
      {

         return new ListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.querySelectorAll(selectors));
      }

// Generating method code for isAncestorOfAny
      public virtual bool IsAncestorOfAny(com.gargoylesoftware.htmlunit.html.DomNode[] nodes)
      {
         return WObj.isAncestorOfAny(nodes);
      }

// Generating method code for hasChildNodes
      public virtual bool HasChildNodes()
      {
         return WObj.hasChildNodes();
      }

// Generating method code for isSupported
      public virtual bool IsSupported(string namespaceArg, string featureName)
      {
         return WObj.isSupported(namespaceArg, featureName);
      }

// Generating method code for compareDocumentPosition
      public virtual System.Int16 CompareDocumentPosition(NHtmlUnit.W3C.Dom.INode other)
      {
         return WObj.compareDocumentPosition((org.w3c.dom.Node)other.WrappedObject);
      }

// Generating method code for isSameNode
      public virtual bool IsSameNode(NHtmlUnit.W3C.Dom.INode other)
      {
         return WObj.isSameNode((org.w3c.dom.Node)other.WrappedObject);
      }

// Generating method code for lookupPrefix
      public virtual string LookupPrefix(string namespaceURI)
      {
         return WObj.lookupPrefix(namespaceURI);
      }

// Generating method code for isDefaultNamespace
      public virtual bool IsDefaultNamespace(string namespaceURI)
      {
         return WObj.isDefaultNamespace(namespaceURI);
      }

// Generating method code for lookupNamespaceURI
      public virtual string LookupNamespaceURI(string prefix)
      {
         return WObj.lookupNamespaceURI(prefix);
      }

// Generating method code for isEqualNode
      public virtual bool IsEqualNode(NHtmlUnit.W3C.Dom.INode arg)
      {
         return WObj.isEqualNode((org.w3c.dom.Node)arg.WrappedObject);
      }

// Generating method code for getFeature
      public virtual object GetFeature(string feature, string version)
      {
         return WObj.getFeature(feature, version);
      }

// Generating method code for getUserData
      public virtual object GetUserData(string key)
      {
         return WObj.getUserData(key);
      }

// Generating method code for setUserData
      public virtual object SetUserData(string key, object data, NHtmlUnit.W3C.Dom.IUserDataHandler handler)
      {
         return WObj.setUserData(key, data, (org.w3c.dom.UserDataHandler)handler.WrappedObject);
      }

// Generating method code for hasAttributes
      public virtual bool HasAttributes()
      {
         return WObj.hasAttributes();
      }

// Generating method code for isDisplayed
      public virtual bool IsDisplayed()
      {
         return WObj.isDisplayed();
      }

// Generating method code for asText
      public virtual string AsText()
      {
         return WObj.asText();
      }

// Generating method code for replaceChild
      public virtual NHtmlUnit.W3C.Dom.INode ReplaceChild(NHtmlUnit.W3C.Dom.INode newChild, NHtmlUnit.W3C.Dom.INode oldChild)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.replaceChild((org.w3c.dom.Node)newChild.WrappedObject, (org.w3c.dom.Node)oldChild.WrappedObject));
      }

// Generating method code for getFirstByXPath
      public virtual object GetFirstByXPath(string xpathExpr)
      {
         return WObj.getFirstByXPath(xpathExpr);
      }

// Generating method code for removeDomChangeListener
      public virtual void RemoveDomChangeListener(NHtmlUnit.Html.IDomChangeListener listener)
      {
         WObj.removeDomChangeListener((com.gargoylesoftware.htmlunit.html.DomChangeListener)listener.WrappedObject);
      }

// Generating method code for querySelector
      public virtual NHtmlUnit.Html.DomNode QuerySelector(string selectors)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(WObj.querySelector(selectors));
      }

// Generating method code for processImportNode
      public virtual void ProcessImportNode(NHtmlUnit.Javascript.Host.Document doc)
      {
         WObj.processImportNode((com.gargoylesoftware.htmlunit.javascript.host.Document)doc.WrappedObject);
      }

   }


}
