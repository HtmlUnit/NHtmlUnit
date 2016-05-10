// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class Document : NHtmlUnit.Javascript.Host.Dom.EventNode
   {
      static Document()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.Document o) =>
            new Document(o));
      }

      public Document(com.gargoylesoftware.htmlunit.javascript.host.dom.Document wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.Document WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.Document)WrappedObject; }
      }

      public Document()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.Document()) {}


      public NHtmlUnit.SgmlPage Page
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.SgmlPage>(
               WObj.getPage());
         }
      }


      public System.String Referrer
      {
         get
         {
            return WObj.getReferrer();
         }
      }

      public NHtmlUnit.Javascript.Host.Element DocumentElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Element>(
               WObj.getDocumentElement());
         }
      }


      public NHtmlUnit.Javascript.SimpleScriptable Doctype
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.SimpleScriptable>(
               WObj.getDoctype());
         }
      }


      public System.String DesignMode
      {
         get
         {
            return WObj.getDesignMode();
         }
         set
         {
            WObj.setDesignMode(value);
         }

      }

      public System.Object DefaultView
      {
         get
         {
            return WObj.getDefaultView();
         }
      }

      public NHtmlUnit.Javascript.Host.Dom.DOMImplementation Implementation
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.DOMImplementation>(
               WObj.getImplementation());
         }
      }

// Generating method code for createDocumentFragment
      public virtual object CreateDocumentFragment()
      {
         var arg = WObj.createDocumentFragment();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createAttribute
      public virtual NHtmlUnit.Javascript.Host.Dom.Attr CreateAttribute(string attributeName)
      {
         var arg = WObj.createAttribute(attributeName);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Attr>(arg);
      }

// Generating method code for importNode
      public virtual object ImportNode(NHtmlUnit.Javascript.Host.Dom.Node importedNode, bool deep)
      {
         var arg = WObj.importNode((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)importedNode.WrappedObject, deep);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for captureEvents
      public virtual void CaptureEvents(string type)
      {
         WObj.captureEvents(type);
      }

// Generating method code for createNSResolver
      public virtual NHtmlUnit.Javascript.Host.Dom.XPathNSResolver CreateNSResolver(NHtmlUnit.Javascript.Host.Dom.Node nodeResolver)
      {
         var arg = WObj.createNSResolver((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)nodeResolver.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.XPathNSResolver>(arg);
      }

// Generating method code for createTextNode
      public virtual object CreateTextNode(string newData)
      {
         var arg = WObj.createTextNode(newData);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createComment
      public virtual object CreateComment(string comment)
      {
         var arg = WObj.createComment(comment);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for evaluate
      public virtual NHtmlUnit.Javascript.Host.Dom.XPathResult Evaluate(string expression, NHtmlUnit.Javascript.Host.Dom.Node contextNode, object resolver, int type, object result)
      {
         var arg = WObj.evaluate(expression, (com.gargoylesoftware.htmlunit.javascript.host.dom.Node)contextNode.WrappedObject, resolver, type, result);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.XPathResult>(arg);
      }

// Generating method code for createElement
      public virtual object CreateElement(string tagName)
      {
         var arg = WObj.createElement(tagName);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createElementNS
      public virtual object CreateElementNS(string namespaceURI, string qualifiedName)
      {
         var arg = WObj.createElementNS(namespaceURI, qualifiedName);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for getElementsByTagName
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLCollection GetElementsByTagName(string tagName)
      {
         var arg = WObj.getElementsByTagName(tagName);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLCollection>(arg);
      }

// Generating method code for getElementsByTagNameNS
      public virtual object GetElementsByTagNameNS(object namespaceURI, string localName)
      {
         var arg = WObj.getElementsByTagNameNS(namespaceURI, localName);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for getLocation
      public virtual NHtmlUnit.Javascript.Host.Location GetLocation()
      {
         var arg = WObj.getLocation();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Location>(arg);
      }

// Generating method code for setLocation
      public virtual void SetLocation(string location)
      {
         WObj.setLocation(location);
      }

   }


}
