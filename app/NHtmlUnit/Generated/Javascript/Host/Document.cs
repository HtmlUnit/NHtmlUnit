// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Document : NHtmlUnit.Javascript.Host.EventNode
   {
      static Document()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Document o) =>
            new Document(o));
      }

      public Document(com.gargoylesoftware.htmlunit.javascript.host.Document wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Document WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Document)WrappedObject; }
      }

      public Document()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Document()) {}

// Generating method code for jsxGet_location
      public virtual NHtmlUnit.Javascript.Host.Location JsxGet_location()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Location>(WObj.jsxGet_location());
      }

// Generating method code for jsxSet_location
      public virtual void JsxSet_location(string location)
      {
         WObj.jsxSet_location(location);
      }

// Generating method code for jsxGet_referrer
      public virtual string JsxGet_referrer()
      {
         return WObj.jsxGet_referrer();
      }

// Generating method code for jsxGet_documentElement
      public virtual NHtmlUnit.Javascript.Host.Element JsxGet_documentElement()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Element>(WObj.jsxGet_documentElement());
      }

// Generating method code for jsxGet_doctype
      public virtual NHtmlUnit.Javascript.SimpleScriptable JsxGet_doctype()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.SimpleScriptable>(WObj.jsxGet_doctype());
      }

// Generating method code for jsxGet_designMode
      public virtual string JsxGet_designMode()
      {
         return WObj.jsxGet_designMode();
      }

// Generating method code for jsxSet_designMode
      public virtual void JsxSet_designMode(string mode)
      {
         WObj.jsxSet_designMode(mode);
      }

// Generating method code for jsxGet_defaultView
      public virtual object JsxGet_defaultView()
      {
         return WObj.jsxGet_defaultView();
      }

// Generating method code for jsxFunction_createDocumentFragment
      public virtual object JsxFunction_createDocumentFragment()
      {
         return WObj.jsxFunction_createDocumentFragment();
      }

// Generating method code for jsxFunction_createAttribute
      public virtual NHtmlUnit.Javascript.Host.Attr JsxFunction_createAttribute(string attributeName)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Attr>(WObj.jsxFunction_createAttribute(attributeName));
      }

// Generating method code for jsxFunction_getBoxObjectFor
      public virtual NHtmlUnit.Javascript.Host.BoxObject JsxFunction_getBoxObjectFor(NHtmlUnit.Javascript.Host.Html.HTMLElement element)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.BoxObject>(WObj.jsxFunction_getBoxObjectFor((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)element.WrappedObject));
      }

// Generating method code for jsxFunction_importNode
      public virtual object JsxFunction_importNode(NHtmlUnit.Javascript.Host.Node importedNode, bool deep)
      {
         return WObj.jsxFunction_importNode((com.gargoylesoftware.htmlunit.javascript.host.Node)importedNode.WrappedObject, deep);
      }

// Generating method code for jsxGet_implementation
      public virtual NHtmlUnit.Javascript.Host.DOMImplementation JsxGet_implementation()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.DOMImplementation>(WObj.jsxGet_implementation());
      }

// Generating method code for jsxFunction_captureEvents
      public virtual void JsxFunction_captureEvents(string type)
      {
         WObj.jsxFunction_captureEvents(type);
      }

// Generating method code for jsxFunction_createNSResolver
      public virtual NHtmlUnit.Javascript.Host.XPathNSResolver JsxFunction_createNSResolver(NHtmlUnit.Javascript.Host.Node nodeResolver)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.XPathNSResolver>(WObj.jsxFunction_createNSResolver((com.gargoylesoftware.htmlunit.javascript.host.Node)nodeResolver.WrappedObject));
      }

// Generating method code for jsxFunction_createTextNode
      public virtual object JsxFunction_createTextNode(string newData)
      {
         return WObj.jsxFunction_createTextNode(newData);
      }

// Generating method code for jsxFunction_createComment
      public virtual object JsxFunction_createComment(string comment)
      {
         return WObj.jsxFunction_createComment(comment);
      }

// Generating method code for jsxFunction_evaluate
      public virtual NHtmlUnit.Javascript.Host.XPathResult JsxFunction_evaluate(string expression, NHtmlUnit.Javascript.Host.Node contextNode, object resolver, int type, object result)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.XPathResult>(WObj.jsxFunction_evaluate(expression, (com.gargoylesoftware.htmlunit.javascript.host.Node)contextNode.WrappedObject, resolver, type, result));
      }

// Generating method code for jsxFunction_createElement
      public virtual object JsxFunction_createElement(string tagName)
      {
         return WObj.jsxFunction_createElement(tagName);
      }

// Generating method code for jsxFunction_createElementNS
      public virtual object JsxFunction_createElementNS(string namespaceURI, string qualifiedName)
      {
         return WObj.jsxFunction_createElementNS(namespaceURI, qualifiedName);
      }

// Generating method code for jsxFunction_getElementsByTagName
      public virtual IList<NHtmlUnit.W3C.Dom.INode> JsxFunction_getElementsByTagName(string tagName)
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.jsxFunction_getElementsByTagName(tagName));
      }

// Generating method code for jsxFunction_getElementsByTagNameNS
      public virtual object JsxFunction_getElementsByTagNameNS(object namespaceURI, string localName)
      {
         return WObj.jsxFunction_getElementsByTagNameNS(namespaceURI, localName);
      }

   }


}
