// Generated class v2.19.0.0, don't modify

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


      public System.Boolean Async
      {
         get
         {
            return WObj.getAsync();
         }
         set
         {
            WObj.setAsync(value);
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


      public System.Boolean PreserveWhiteSpace
      {
         get
         {
            return WObj.getPreserveWhiteSpace();
         }
         set
         {
            WObj.setPreserveWhiteSpace(value);
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
         return WObj.createAttribute(name);
      }

// Generating method code for createCDATASection
      public virtual object CreateCDATASection(string data)
      {
         return WObj.createCDATASection(data);
      }

// Generating method code for createComment
      public virtual object CreateComment(string data)
      {
         return WObj.createComment(data);
      }

// Generating method code for createDocumentFragment
      public virtual object CreateDocumentFragment()
      {
         return WObj.createDocumentFragment();
      }

// Generating method code for createElement
      public virtual object CreateElement(string tagName)
      {
         return WObj.createElement(tagName);
      }

// Generating method code for createNode
      public virtual object CreateNode(object type, string name, object namespaceURI)
      {
         return WObj.createNode(type, name, namespaceURI);
      }

// Generating method code for createProcessingInstruction
      public virtual object CreateProcessingInstruction(string target, string data)
      {
         return WObj.createProcessingInstruction(target, data);
      }

// Generating method code for createTextNode
      public virtual object CreateTextNode(string data)
      {
         return WObj.createTextNode(data);
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
         return WObj.nodeFromID(id);
      }

// Generating method code for setProperty
      public virtual void SetProperty(string name, string value)
      {
         WObj.setProperty(name, value);
      }

   }


}
