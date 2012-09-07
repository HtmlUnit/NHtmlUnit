// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Element : NHtmlUnit.Javascript.Host.EventNode
   {
      static Element()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Element o) =>
            new Element(o));
      }

      public Element(com.gargoylesoftware.htmlunit.javascript.host.Element wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Element WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Element)WrappedObject; }
      }

      public Element()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Element()) {}


      public System.Int32 PosX
      {
         get
         {
            return WObj.getPosX();
         }
      }

      public System.Int32 PosY
      {
         get
         {
            return WObj.getPosY();
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

// Generating method code for jsxGet_currentStyle
      public virtual NHtmlUnit.Javascript.Host.Css.ComputedCSSStyleDeclaration JsxGet_currentStyle()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.ComputedCSSStyleDeclaration>(WObj.jsxGet_currentStyle());
      }

// Generating method code for jsxGet_tagName
      public virtual string JsxGet_tagName()
      {
         return WObj.jsxGet_tagName();
      }

// Generating method code for jsxFunction_selectNodes
      public virtual IList<NHtmlUnit.W3C.Dom.INode> JsxFunction_selectNodes(string expression)
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.jsxFunction_selectNodes(expression));
      }

// Generating method code for jsxGet_offsetParent
      public virtual object JsxGet_offsetParent()
      {
         return WObj.jsxGet_offsetParent();
      }

// Generating method code for jsxGet_offsetLeft
      public virtual int JsxGet_offsetLeft()
      {
         return WObj.jsxGet_offsetLeft();
      }

// Generating method code for jsxGet_offsetTop
      public virtual int JsxGet_offsetTop()
      {
         return WObj.jsxGet_offsetTop();
      }

// Generating method code for jsxFunction_selectSingleNode
      public virtual object JsxFunction_selectSingleNode(string expression)
      {
         return WObj.jsxFunction_selectSingleNode(expression);
      }

// Generating method code for jsxGet_attributes
      public virtual object JsxGet_attributes()
      {
         return WObj.jsxGet_attributes();
      }

// Generating method code for jsxFunction_getAttribute
      public virtual object JsxFunction_getAttribute(string attributeName, java.lang.Integer flags)
      {
         return WObj.jsxFunction_getAttribute(attributeName, flags);
      }

// Generating method code for jsxFunction_setAttribute
      public virtual void JsxFunction_setAttribute(string name, string value)
      {
         WObj.jsxFunction_setAttribute(name, value);
      }

// Generating method code for jsxFunction_getElementsByTagName
      public virtual object JsxFunction_getElementsByTagName(string tagName)
      {
         return WObj.jsxFunction_getElementsByTagName(tagName);
      }

// Generating method code for jsxFunction_getAttributeNode
      public virtual object JsxFunction_getAttributeNode(string name)
      {
         return WObj.jsxFunction_getAttributeNode(name);
      }

// Generating method code for jsxGet_text
      public virtual string JsxGet_text()
      {
         return WObj.jsxGet_text();
      }

// Generating method code for jsxFunction_getElementsByTagNameNS
      public virtual object JsxFunction_getElementsByTagNameNS(object namespaceURI, string localName)
      {
         return WObj.jsxFunction_getElementsByTagNameNS(namespaceURI, localName);
      }

// Generating method code for jsxFunction_hasAttribute
      public virtual bool JsxFunction_hasAttribute(string name)
      {
         return WObj.jsxFunction_hasAttribute(name);
      }

// Generating method code for jsxFunction_removeAttribute
      public virtual void JsxFunction_removeAttribute(string name)
      {
         WObj.jsxFunction_removeAttribute(name);
      }

// Generating method code for jsxFunction_getBoundingClientRect
      public virtual NHtmlUnit.Javascript.Host.ClientRect JsxFunction_getBoundingClientRect()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.ClientRect>(WObj.jsxFunction_getBoundingClientRect());
      }

// Generating method code for jsxGet_clientLeft
      public virtual int JsxGet_clientLeft()
      {
         return WObj.jsxGet_clientLeft();
      }

// Generating method code for jsxGet_clientTop
      public virtual int JsxGet_clientTop()
      {
         return WObj.jsxGet_clientTop();
      }

// Generating method code for jsxGet_style
      public virtual NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration JsxGet_style()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration>(WObj.jsxGet_style());
      }

// Generating method code for jsxGet_runtimeStyle
      public virtual NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration JsxGet_runtimeStyle()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration>(WObj.jsxGet_runtimeStyle());
      }

   }


}
