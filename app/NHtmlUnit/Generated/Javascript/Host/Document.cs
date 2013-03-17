// Generated class v5, don't modify

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
         return WObj.createDocumentFragment();
      }

// Generating method code for createAttribute
      public virtual NHtmlUnit.Javascript.Host.Attr CreateAttribute(string attributeName)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Attr>(WObj.createAttribute(attributeName));
      }

// Generating method code for getBoxObjectFor
      public virtual NHtmlUnit.Javascript.Host.BoxObject GetBoxObjectFor(NHtmlUnit.Javascript.Host.Html.HTMLElement element)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.BoxObject>(WObj.getBoxObjectFor((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)element.WrappedObject));
      }

// Generating method code for importNode
      public virtual object ImportNode(NHtmlUnit.Javascript.Host.Node importedNode, bool deep)
      {
         return WObj.importNode((com.gargoylesoftware.htmlunit.javascript.host.Node)importedNode.WrappedObject, deep);
      }

// Generating method code for captureEvents
      public virtual void CaptureEvents(string type)
      {
         WObj.captureEvents(type);
      }

// Generating method code for createNSResolver
      public virtual NHtmlUnit.Javascript.Host.XPathNSResolver CreateNSResolver(NHtmlUnit.Javascript.Host.Node nodeResolver)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.XPathNSResolver>(WObj.createNSResolver((com.gargoylesoftware.htmlunit.javascript.host.Node)nodeResolver.WrappedObject));
      }

// Generating method code for createTextNode
      public virtual object CreateTextNode(string newData)
      {
         return WObj.createTextNode(newData);
      }

// Generating method code for createComment
      public virtual object CreateComment(string comment)
      {
         return WObj.createComment(comment);
      }

// Generating method code for evaluate
      public virtual NHtmlUnit.Javascript.Host.XPathResult Evaluate(string expression, NHtmlUnit.Javascript.Host.Node contextNode, object resolver, int type, object result)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.XPathResult>(WObj.evaluate(expression, (com.gargoylesoftware.htmlunit.javascript.host.Node)contextNode.WrappedObject, resolver, type, result));
      }

// Generating method code for createElement
      public virtual object CreateElement(string tagName)
      {
         return WObj.createElement(tagName);
      }

// Generating method code for createElementNS
      public virtual object CreateElementNS(string namespaceURI, string qualifiedName)
      {
         return WObj.createElementNS(namespaceURI, qualifiedName);
      }

// Generating method code for getElementsByTagName
      public virtual IList<NHtmlUnit.W3C.Dom.INode> GetElementsByTagName(string tagName)
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.getElementsByTagName(tagName));
      }

// Generating method code for getElementsByTagNameNS
      public virtual object GetElementsByTagNameNS(object namespaceURI, string localName)
      {
         return WObj.getElementsByTagNameNS(namespaceURI, localName);
      }

// Generating method code for getLocation
      public virtual NHtmlUnit.Javascript.Host.Location GetLocation()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Location>(WObj.getLocation());
      }

// Generating method code for setLocation
      public virtual void SetLocation(string location)
      {
         WObj.setLocation(location);
      }

   }


}
