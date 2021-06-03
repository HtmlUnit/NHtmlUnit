// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class XMLDOMDocument : NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode
   {
      static XMLDOMDocument()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMDocument o) =>
            new XMLDOMDocument(o));
      }

      public XMLDOMDocument(com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMDocument wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMDocument WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMDocument)WrappedObject; }
      }

      public XMLDOMDocument(NHtmlUnit.IWebWindow enclosingWindow)
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMDocument((com.gargoylesoftware.htmlunit.WebWindow)enclosingWindow.WrappedObject)) {}

      public XMLDOMDocument()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMDocument()) {}


      public NHtmlUnit.Activex.Javascript.Msxml.XMLDOMElement DocumentElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Activex.Javascript.Msxml.XMLDOMElement>(
               WObj.getDocumentElement());
         }
         set
         {
            WObj.setDocumentElement((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMElement)value.WrappedObject);
         }

      }


      public NHtmlUnit.Activex.Javascript.Msxml.XMLDOMParseError ParseError
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Activex.Javascript.Msxml.XMLDOMParseError>(
               WObj.getParseError());
         }
      }


      public NHtmlUnit.Activex.Javascript.Msxml.XMLDOMDocumentType Doctype
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Activex.Javascript.Msxml.XMLDOMDocumentType>(
               WObj.getDoctype());
         }
      }


      public NHtmlUnit.Activex.Javascript.Msxml.XMLDOMImplementation Implementation
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Activex.Javascript.Msxml.XMLDOMImplementation>(
               WObj.getImplementation());
         }
      }


      public System.String Url
      {
         get
         {
            return WObj.getUrl();
         }
      }
// Generating method code for isPreserveWhiteSpaceDuringLoad
      public virtual bool IsPreserveWhiteSpaceDuringLoad()
      {
         return WObj.isPreserveWhiteSpaceDuringLoad();
      }

// Generating method code for createAttribute
      public virtual object CreateAttribute(string name)
      {
         var arg = WObj.createAttribute(name);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for isAsync
      public virtual bool IsAsync()
      {
         return WObj.isAsync();
      }

// Generating method code for isPreserveWhiteSpace
      public virtual bool IsPreserveWhiteSpace()
      {
         return WObj.isPreserveWhiteSpace();
      }

// Generating method code for createCDATASection
      public virtual object CreateCDATASection(string data)
      {
         var arg = WObj.createCDATASection(data);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createComment
      public virtual object CreateComment(string data)
      {
         var arg = WObj.createComment(data);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createDocumentFragment
      public virtual object CreateDocumentFragment()
      {
         var arg = WObj.createDocumentFragment();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createElement
      public virtual object CreateElement(string tagName)
      {
         var arg = WObj.createElement(tagName);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createNode
      public virtual object CreateNode(object type, string name, object namespaceURI)
      {
         var arg = WObj.createNode(type, name, namespaceURI);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createProcessingInstruction
      public virtual object CreateProcessingInstruction(string target, string data)
      {
         var arg = WObj.createProcessingInstruction(target, data);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createTextNode
      public virtual object CreateTextNode(string data)
      {
         var arg = WObj.createTextNode(data);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for getElementsByTagName
      public virtual IList<NHtmlUnit.W3C.Dom.INode> GetElementsByTagName(string tagName)
      {

return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.getElementsByTagName(tagName));
      }

// Generating method code for getProperty
      public virtual string GetProperty(string name)
      {
         return WObj.getProperty(name);
      }

// Generating method code for load
      public virtual bool Load(string xmlSource)
      {
         return WObj.load(xmlSource);
      }

// Generating method code for loadXML
      public virtual bool LoadXML(string strXML)
      {
         return WObj.loadXML(strXML);
      }

// Generating method code for nodeFromID
      public virtual object NodeFromID(string id)
      {
         var arg = WObj.nodeFromID(id);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for setProperty
      public virtual void SetProperty(string name, string value)
      {
         WObj.setProperty(name, value);
      }

   }


}
