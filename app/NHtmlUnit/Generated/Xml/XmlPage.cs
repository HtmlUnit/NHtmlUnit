// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Xml
{
   public partial class XmlPage : NHtmlUnit.SgmlPage, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.IPage, NHtmlUnit.W3C.Dom.IDocument
   {
      static XmlPage()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.xml.XmlPage o) =>
            new XmlPage(o));
      }

      public XmlPage(com.gargoylesoftware.htmlunit.xml.XmlPage wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.xml.XmlPage WObj
      {
         get { return (com.gargoylesoftware.htmlunit.xml.XmlPage)WrappedObject; }
      }

      public XmlPage(NHtmlUnit.WebResponse webResponse, NHtmlUnit.IWebWindow enclosingWindow, bool ignoreSAXException, bool handleXHTMLAsHTML)
         : this(new com.gargoylesoftware.htmlunit.xml.XmlPage((com.gargoylesoftware.htmlunit.WebResponse)webResponse.WrappedObject, (com.gargoylesoftware.htmlunit.WebWindow)enclosingWindow.WrappedObject, ignoreSAXException, handleXHTMLAsHTML)) {}

      public XmlPage(NHtmlUnit.WebResponse webResponse, NHtmlUnit.IWebWindow enclosingWindow)
         : this(new com.gargoylesoftware.htmlunit.xml.XmlPage((com.gargoylesoftware.htmlunit.WebResponse)webResponse.WrappedObject, (com.gargoylesoftware.htmlunit.WebWindow)enclosingWindow.WrappedObject)) {}

      public XmlPage(NHtmlUnit.WebResponse webResponse, NHtmlUnit.IWebWindow enclosingWindow, bool ignoreSAXException)
         : this(new com.gargoylesoftware.htmlunit.xml.XmlPage((com.gargoylesoftware.htmlunit.WebResponse)webResponse.WrappedObject, (com.gargoylesoftware.htmlunit.WebWindow)enclosingWindow.WrappedObject, ignoreSAXException)) {}

      public XmlPage(NHtmlUnit.W3C.Dom.INode node, NHtmlUnit.IWebWindow enclosingWindow)
         : this(new com.gargoylesoftware.htmlunit.xml.XmlPage((org.w3c.dom.Node)node.WrappedObject, (com.gargoylesoftware.htmlunit.WebWindow)enclosingWindow.WrappedObject)) {}


      public System.String Content
      {
         get
         {
            return WObj.getContent();
         }
      }

      public NHtmlUnit.W3C.Dom.IDocument XmlDocument
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IDocument>(
               WObj.getXmlDocument());
         }
      }

// Generating method code for createXmlElementNS
      public virtual NHtmlUnit.Html.DomElement CreateXmlElementNS(string namespaceURI, string qualifiedName)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomElement>(WObj.createXmlElementNS(namespaceURI, qualifiedName));
      }

// Generating method code for createXmlElement
      public virtual NHtmlUnit.Html.DomElement CreateXmlElement(string tagName)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomElement>(WObj.createXmlElement(tagName));
      }

   }


}
