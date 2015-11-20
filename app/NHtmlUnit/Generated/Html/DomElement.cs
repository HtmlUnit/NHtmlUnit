// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class DomElement : NHtmlUnit.Html.DomNamespaceNode, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
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


      public System.String Id
      {
         get
         {
            return WObj.getId();
         }
      }

      public java.util.Map AttributesMap
      {
         get
         {
            return WObj.getAttributesMap();
         }
      }

      public System.String TagName
      {
         get
         {
            return WObj.getTagName();
         }
      }

      public IEnumerable<NHtmlUnit.Html.DomElement> ChildElements
      {
         get
         {
            return new IterableWrapper<NHtmlUnit.Html.DomElement>(
               WObj.getChildElements());
         }
       }

      public NHtmlUnit.Html.DomElement NextElementSibling
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomElement>(
               WObj.getNextElementSibling());
         }
      }


      public NHtmlUnit.Html.DomElement PreviousElementSibling
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomElement>(
               WObj.getPreviousElementSibling());
         }
      }


      public NHtmlUnit.Html.DomElement LastElementChild
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomElement>(
               WObj.getLastElementChild());
         }
      }


      public NHtmlUnit.Html.DomElement FirstElementChild
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomElement>(
               WObj.getFirstElementChild());
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


      public System.Int32 ChildElementCount
      {
         get
         {
            return WObj.getChildElementCount();
         }
      }
// Generating method code for getAttribute
      public virtual string GetAttribute(string attributeName)
      {
         return WObj.getAttribute(attributeName);
      }

// Generating method code for removeAttribute
      public virtual void RemoveAttribute(string attributeName)
      {
         WObj.removeAttribute(attributeName);
      }

// Generating method code for setAttribute
      public virtual void SetAttribute(string attributeName, string attributeValue)
      {
         WObj.setAttribute(attributeName, attributeValue);
      }

// Generating method code for setAttributeNode
      public virtual NHtmlUnit.W3C.Dom.IAttr SetAttributeNode(NHtmlUnit.W3C.Dom.IAttr attribute)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IAttr>(WObj.setAttributeNode((org.w3c.dom.Attr)attribute.WrappedObject));
      }

// Generating method code for setAttributeNS
      public virtual void SetAttributeNS(string namespaceURI, string qualifiedName, string attributeValue)
      {
         WObj.setAttributeNS(namespaceURI, qualifiedName, attributeValue);
      }

// Generating method code for click
      public virtual NHtmlUnit.IPage Click(bool shiftKey, bool ctrlKey, bool altKey)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.click(shiftKey, ctrlKey, altKey));
      }

// Generating method code for mouseDown
      public virtual NHtmlUnit.IPage MouseDown(bool shiftKey, bool ctrlKey, bool altKey, int button)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseDown(shiftKey, ctrlKey, altKey, button));
      }

// Generating method code for mouseUp
      public virtual NHtmlUnit.IPage MouseUp(bool shiftKey, bool ctrlKey, bool altKey, int button)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseUp(shiftKey, ctrlKey, altKey, button));
      }

// Generating method code for click
      public virtual NHtmlUnit.IPage Click(NHtmlUnit.Javascript.Host.Events.Event eventArg)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.click((com.gargoylesoftware.htmlunit.javascript.host.@event.Event)eventArg.WrappedObject));
      }

// Generating method code for fireEvent
      public virtual NHtmlUnit.ScriptResult FireEvent(NHtmlUnit.Javascript.Host.Events.Event eventArg)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.fireEvent((com.gargoylesoftware.htmlunit.javascript.host.@event.Event)eventArg.WrappedObject));
      }

// Generating method code for dblClick
      public virtual NHtmlUnit.IPage DblClick(bool shiftKey, bool ctrlKey, bool altKey)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.dblClick(shiftKey, ctrlKey, altKey));
      }

// Generating method code for mouseOver
      public virtual NHtmlUnit.IPage MouseOver(bool shiftKey, bool ctrlKey, bool altKey, int button)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseOver(shiftKey, ctrlKey, altKey, button));
      }

// Generating method code for mouseMove
      public virtual NHtmlUnit.IPage MouseMove(bool shiftKey, bool ctrlKey, bool altKey, int button)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseMove(shiftKey, ctrlKey, altKey, button));
      }

// Generating method code for mouseOut
      public virtual NHtmlUnit.IPage MouseOut(bool shiftKey, bool ctrlKey, bool altKey, int button)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseOut(shiftKey, ctrlKey, altKey, button));
      }

// Generating method code for rightClick
      public virtual NHtmlUnit.IPage RightClick(bool shiftKey, bool ctrlKey, bool altKey)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.rightClick(shiftKey, ctrlKey, altKey));
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

// Generating method code for click
      public virtual NHtmlUnit.IPage Click()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.click());
      }

// Generating method code for dblClick
      public virtual NHtmlUnit.IPage DblClick()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.dblClick());
      }

// Generating method code for mouseOver
      public virtual NHtmlUnit.IPage MouseOver()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseOver());
      }

// Generating method code for mouseMove
      public virtual NHtmlUnit.IPage MouseMove()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseMove());
      }

// Generating method code for mouseOut
      public virtual NHtmlUnit.IPage MouseOut()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseOut());
      }

// Generating method code for mouseDown
      public virtual NHtmlUnit.IPage MouseDown()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseDown());
      }

// Generating method code for mouseUp
      public virtual NHtmlUnit.IPage MouseUp()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.mouseUp());
      }

// Generating method code for rightClick
      public virtual NHtmlUnit.IPage RightClick()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.rightClick());
      }

// Generating method code for fireEvent
      public virtual NHtmlUnit.ScriptResult FireEvent(string eventType)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.ScriptResult>(WObj.fireEvent(eventType));
      }

// Generating method code for focus
      public virtual void Focus()
      {
         WObj.focus();
      }

// Generating method code for blur
      public virtual void Blur()
      {
         WObj.blur();
      }

// Generating method code for removeFocus
      public virtual void RemoveFocus()
      {
         WObj.removeFocus();
      }

   }


}
