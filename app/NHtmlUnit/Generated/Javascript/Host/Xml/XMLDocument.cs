// Generated class v4, don't modify

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

// Generating method code for jsxFunction_loadXML
      public virtual bool JsxFunction_loadXML(string strXML)
      {
         return WObj.jsxFunction_loadXML(strXML);
      }

// Generating method code for jsxGet_parseError
      public virtual NHtmlUnit.Javascript.Host.Xml.XMLDOMParseError JsxGet_parseError()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Xml.XMLDOMParseError>(WObj.jsxGet_parseError());
      }

// Generating method code for jsxFunction_selectNodes
      public virtual IList<NHtmlUnit.W3C.Dom.INode> JsxFunction_selectNodes(string expression)
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.jsxFunction_selectNodes(expression));
      }

// Generating method code for jsxSet_async
      public virtual void JsxSet_async(bool async)
      {
         WObj.jsxSet_async(async);
      }

// Generating method code for jsxGet_async
      public virtual bool JsxGet_async()
      {
         return WObj.jsxGet_async();
      }

// Generating method code for jsxFunction_load
      public virtual bool JsxFunction_load(string xmlSource)
      {
         return WObj.jsxFunction_load(xmlSource);
      }

// Generating method code for jsxGet_preserveWhiteSpace
      public virtual bool JsxGet_preserveWhiteSpace()
      {
         return WObj.jsxGet_preserveWhiteSpace();
      }

// Generating method code for jsxSet_preserveWhiteSpace
      public virtual void JsxSet_preserveWhiteSpace(bool preserveWhiteSpace)
      {
         WObj.jsxSet_preserveWhiteSpace(preserveWhiteSpace);
      }

// Generating method code for jsxFunction_setProperty
      public virtual void JsxFunction_setProperty(string name, string value)
      {
         WObj.jsxFunction_setProperty(name, value);
      }

// Generating method code for jsxFunction_selectSingleNode
      public virtual object JsxFunction_selectSingleNode(string expression)
      {
         return WObj.jsxFunction_selectSingleNode(expression);
      }

// Generating method code for jsxFunction_getElementById
      public virtual object JsxFunction_getElementById(string id)
      {
         return WObj.jsxFunction_getElementById(id);
      }

// Generating method code for jsxFunction_nodeFromID
      public virtual object JsxFunction_nodeFromID(string id)
      {
         return WObj.jsxFunction_nodeFromID(id);
      }

// Generating method code for jsxFunction_createProcessingInstruction
      public virtual object JsxFunction_createProcessingInstruction(string target, string data)
      {
         return WObj.jsxFunction_createProcessingInstruction(target, data);
      }

// Generating method code for jsxFunction_createCDATASection
      public virtual object JsxFunction_createCDATASection(string data)
      {
         return WObj.jsxFunction_createCDATASection(data);
      }

// Generating method code for jsxFunction_createNode
      public virtual object JsxFunction_createNode(object type, string name, object namespaceURI)
      {
         return WObj.jsxFunction_createNode(type, name, namespaceURI);
      }

   }


}
