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

// Generating method code for jsxFunction_selectNodes
      public virtual IList<NHtmlUnit.W3C.Dom.INode> JsxFunction_selectNodes(string expression)
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.jsxFunction_selectNodes(expression));
      }

// Generating method code for jsxFunction_selectSingleNode
      public virtual object JsxFunction_selectSingleNode(string expression)
      {
         return WObj.jsxFunction_selectSingleNode(expression);
      }

// Generating method code for jsxGet_tagName
      public virtual string JsxGet_tagName()
      {
         return WObj.jsxGet_tagName();
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

   }


}
