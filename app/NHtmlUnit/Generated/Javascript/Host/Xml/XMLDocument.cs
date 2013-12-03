// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Xml
{
   public partial class XMLDocument : NHtmlUnit.Javascript.Host.Document
   {
      static XMLDocument()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDocument o) =>
            new XMLDocument(o));
      }

      public XMLDocument(com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDocument wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDocument WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDocument)WrappedObject; }
      }

      public XMLDocument(NHtmlUnit.IWebWindow enclosingWindow)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDocument((com.gargoylesoftware.htmlunit.WebWindow)enclosingWindow.WrappedObject)) {}

      public XMLDocument()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLDocument()) {}


      public NHtmlUnit.Javascript.Host.Xml.XMLDOMParseError ParseError
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Xml.XMLDOMParseError>(
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
// Generating method code for loadXML
      public virtual bool LoadXML(string strXML)
      {
         return WObj.loadXML(strXML);
      }

// Generating method code for selectNodes
      public virtual IList<NHtmlUnit.W3C.Dom.INode> SelectNodes(string expression)
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.selectNodes(expression));
      }

// Generating method code for load
      public virtual bool Load(string xmlSource)
      {
         return WObj.load(xmlSource);
      }

// Generating method code for setProperty
      public virtual void SetProperty(string name, string value)
      {
         WObj.setProperty(name, value);
      }

// Generating method code for getProperty
      public virtual string GetProperty(string name)
      {
         return WObj.getProperty(name);
      }

// Generating method code for selectSingleNode
      public virtual object SelectSingleNode(string expression)
      {
         return WObj.selectSingleNode(expression);
      }

// Generating method code for getElementById
      public virtual object GetElementById(string id)
      {
         return WObj.getElementById(id);
      }

// Generating method code for nodeFromID
      public virtual object NodeFromID(string id)
      {
         return WObj.nodeFromID(id);
      }

// Generating method code for createProcessingInstruction
      public virtual object CreateProcessingInstruction(string target, string data)
      {
         return WObj.createProcessingInstruction(target, data);
      }

// Generating method code for createCDATASection
      public virtual object CreateCDATASection(string data)
      {
         return WObj.createCDATASection(data);
      }

// Generating method code for createNode
      public virtual object CreateNode(object type, string name, object namespaceURI)
      {
         return WObj.createNode(type, name, namespaceURI);
      }

   }


}
