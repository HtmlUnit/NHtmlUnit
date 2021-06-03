// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Xml
{
   public partial class XmlPage : NHtmlUnit.SgmlPage, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.IPage, NHtmlUnit.W3C.Dom.IDocument, NHtmlUnit.W3C.Dom.Traversal.IDocumentTraversal
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


      public NHtmlUnit.W3C.Dom.IDocument XmlDocument
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IDocument>(
               WObj.getXmlDocument());
         }
      }

   }


}
