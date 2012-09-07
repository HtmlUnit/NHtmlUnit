// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class DomElement : NHtmlUnit.Html.DomNamespaceNode, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static DomElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.DomElement o) =>
            new DomElement(o));
      }

      public DomElement(com.gargoylesoftware.htmlunit.html.DomElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.DomElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.DomElement)WrappedObject; }
      }

      public DomElement(string namespaceURI, string qualifiedName, NHtmlUnit.SgmlPage page, java.util.Map attributes)
         : this(new com.gargoylesoftware.htmlunit.html.DomElement(namespaceURI, qualifiedName, (com.gargoylesoftware.htmlunit.SgmlPage)page.WrappedObject, attributes)) {}


      public System.String TagName
      {
         get
         {
            return WObj.getTagName();
         }
      }

      public java.util.Map AttributesMap
      {
         get
         {
            return WObj.getAttributesMap();
         }
      }

      public NHtmlUnit.W3C.Dom.ITypeInfo SchemaTypeInfo
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.ITypeInfo>(
               WObj.getSchemaTypeInfo());
         }
      }


      public System.String Id
      {
         get
         {
            return WObj.getId();
         }
      }
// Generating method code for removeAttribute
      public virtual void RemoveAttribute(string attributeName)
      {
         WObj.removeAttribute(attributeName);
      }

// Generating method code for setAttributeNS
      public virtual void SetAttributeNS(string namespaceURI, string qualifiedName, string attributeValue)
      {
         WObj.setAttributeNS(namespaceURI, qualifiedName, attributeValue);
      }

// Generating method code for getAttribute
      public virtual string GetAttribute(string attributeName)
      {
         return WObj.getAttribute(attributeName);
      }

// Generating method code for getElementsByTagNameNS
      public virtual IList<NHtmlUnit.W3C.Dom.INode> GetElementsByTagNameNS(string namespaceArg, string localName)
      {

         return new ListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.getElementsByTagNameNS(namespaceArg, localName));
      }

// Generating method code for getAttributeNodeNS
      public virtual NHtmlUnit.Html.DomAttr GetAttributeNodeNS(string namespaceURI, string localName)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomAttr>(WObj.getAttributeNodeNS(namespaceURI, localName));
      }

// Generating method code for getElementsByTagName
      public virtual IList<NHtmlUnit.W3C.Dom.INode> GetElementsByTagName(string tagName)
      {

         return new ListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.getElementsByTagName(tagName));
      }

// Generating method code for getAttributeNode
      public virtual NHtmlUnit.Html.DomAttr GetAttributeNode(string name)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomAttr>(WObj.getAttributeNode(name));
      }

// Generating method code for hasAttribute
      public virtual bool HasAttribute(string attributeName)
      {
         return WObj.hasAttribute(attributeName);
      }

// Generating method code for removeAttributeNS
      public virtual void RemoveAttributeNS(string namespaceURI, string localName)
      {
         WObj.removeAttributeNS(namespaceURI, localName);
      }

// Generating method code for removeAttributeNode
      public virtual NHtmlUnit.W3C.Dom.IAttr RemoveAttributeNode(NHtmlUnit.W3C.Dom.IAttr attribute)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IAttr>(WObj.removeAttributeNode((org.w3c.dom.Attr)attribute.WrappedObject));
      }

// Generating method code for hasAttributeNS
      public virtual bool HasAttributeNS(string namespaceURI, string localName)
      {
         return WObj.hasAttributeNS(namespaceURI, localName);
      }

// Generating method code for setAttribute
      public virtual void SetAttribute(string attributeName, string attributeValue)
      {
         WObj.setAttribute(attributeName, attributeValue);
      }

// Generating method code for getAttributeNS
      public virtual string GetAttributeNS(string namespaceURI, string localName)
      {
         return WObj.getAttributeNS(namespaceURI, localName);
      }

// Generating method code for setIdAttribute
      public virtual void SetIdAttribute(string name, bool isId)
      {
         WObj.setIdAttribute(name, isId);
      }

// Generating method code for setIdAttributeNS
      public virtual void SetIdAttributeNS(string namespaceURI, string localName, bool isId)
      {
         WObj.setIdAttributeNS(namespaceURI, localName, isId);
      }

// Generating method code for setAttributeNode
      public virtual NHtmlUnit.W3C.Dom.IAttr SetAttributeNode(NHtmlUnit.W3C.Dom.IAttr attribute)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IAttr>(WObj.setAttributeNode((org.w3c.dom.Attr)attribute.WrappedObject));
      }

// Generating method code for setAttributeNodeNS
      public virtual NHtmlUnit.W3C.Dom.IAttr SetAttributeNodeNS(NHtmlUnit.W3C.Dom.IAttr attribute)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IAttr>(WObj.setAttributeNodeNS((org.w3c.dom.Attr)attribute.WrappedObject));
      }

// Generating method code for setIdAttributeNode
      public virtual void SetIdAttributeNode(NHtmlUnit.W3C.Dom.IAttr idAttr, bool isId)
      {
         WObj.setIdAttributeNode((org.w3c.dom.Attr)idAttr.WrappedObject, isId);
      }

   }


}
