// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class SgmlPage : NHtmlUnit.Html.DomNode, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.IPage, NHtmlUnit.W3C.Dom.IDocument
   {
      static SgmlPage()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.SgmlPage o) =>
            new SgmlPage(o));
      }

      public SgmlPage(com.gargoylesoftware.htmlunit.SgmlPage wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.SgmlPage WObj
      {
         get { return (com.gargoylesoftware.htmlunit.SgmlPage)WrappedObject; }
      }


      public System.String PageEncoding
      {
         get
         {
            return WObj.getPageEncoding();
         }
      }

      public NHtmlUnit.Html.DomElement DocumentElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomElement>(
               WObj.getDocumentElement());
         }
      }


      public System.String InputEncoding
      {
         get
         {
            return WObj.getInputEncoding();
         }
      }

      public System.String XmlEncoding
      {
         get
         {
            return WObj.getXmlEncoding();
         }
      }

      public System.Boolean XmlStandalone
      {
         get
         {
            return WObj.getXmlStandalone();
         }
         set
         {
            WObj.setXmlStandalone(value);
         }

      }

      public System.String XmlVersion
      {
         get
         {
            return WObj.getXmlVersion();
         }
         set
         {
            WObj.setXmlVersion(value);
         }

      }

      public System.Boolean StrictErrorChecking
      {
         get
         {
            return WObj.getStrictErrorChecking();
         }
         set
         {
            WObj.setStrictErrorChecking(value);
         }

      }

      public System.String DocumentURI
      {
         get
         {
            return WObj.getDocumentURI();
         }
         set
         {
            WObj.setDocumentURI(value);
         }

      }

      public NHtmlUnit.W3C.Dom.IDOMConfiguration DomConfig
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IDOMConfiguration>(
               WObj.getDomConfig());
         }
      }


      public NHtmlUnit.W3C.Dom.IDOMImplementation Implementation
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IDOMImplementation>(
               WObj.getImplementation());
         }
      }


      public NHtmlUnit.IWebWindow EnclosingWindow
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IWebWindow>(
               WObj.getEnclosingWindow());
         }
         set
         {
            WObj.setEnclosingWindow((com.gargoylesoftware.htmlunit.WebWindow)value.WrappedObject);
         }

      }


      public NHtmlUnit.WebClient WebClient
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.WebClient>(
               WObj.getWebClient());
         }
      }


      public NHtmlUnit.W3C.Dom.IDocumentType Doctype
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IDocumentType>(
               WObj.getDoctype());
         }
      }


      public java.net.URL Url
      {
         get
         {
            return WObj.getUrl();
         }
      }

      public NHtmlUnit.WebResponse WebResponse
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.WebResponse>(
               WObj.getWebResponse());
         }
      }

// Generating method code for isHtmlPage
      public virtual bool IsHtmlPage()
      {
         return WObj.isHtmlPage();
      }

// Generating method code for cleanUp
      public virtual void CleanUp()
      {
         WObj.cleanUp();
      }

// Generating method code for createElement
      public virtual NHtmlUnit.W3C.Dom.IElement CreateElement(string str)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IElement>(WObj.createElement(str));
      }

// Generating method code for getElementById
      public virtual NHtmlUnit.W3C.Dom.IElement GetElementById(string arg0)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IElement>(WObj.getElementById(arg0));
      }

// Generating method code for createElementNS
      public virtual NHtmlUnit.W3C.Dom.IElement CreateElementNS(string str1, string str2)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IElement>(WObj.createElementNS(str1, str2));
      }

// Generating method code for getElementsByTagNameNS
      public virtual IList<NHtmlUnit.W3C.Dom.INode> GetElementsByTagNameNS(string arg0, string arg1)
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.getElementsByTagNameNS(arg0, arg1));
      }

// Generating method code for getElementsByTagName
      public virtual IList<NHtmlUnit.W3C.Dom.INode> GetElementsByTagName(string arg0)
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.getElementsByTagName(arg0));
      }

// Generating method code for hasCaseSensitiveTagNames
      public virtual bool HasCaseSensitiveTagNames()
      {
         return WObj.hasCaseSensitiveTagNames();
      }

// Generating method code for initialize
      public virtual void Initialize()
      {
         WObj.initialize();
      }

// Generating method code for importNode
      public virtual NHtmlUnit.W3C.Dom.INode ImportNode(NHtmlUnit.W3C.Dom.INode arg0, bool arg1)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.importNode((org.w3c.dom.Node)arg0.WrappedObject, arg1));
      }

// Generating method code for adoptNode
      public virtual NHtmlUnit.W3C.Dom.INode AdoptNode(NHtmlUnit.W3C.Dom.INode arg0)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.adoptNode((org.w3c.dom.Node)arg0.WrappedObject));
      }

// Generating method code for renameNode
      public virtual NHtmlUnit.W3C.Dom.INode RenameNode(NHtmlUnit.W3C.Dom.INode arg0, string arg1, string arg2)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.renameNode((org.w3c.dom.Node)arg0.WrappedObject, arg1, arg2));
      }

// Generating method code for createAttributeNS
      public virtual NHtmlUnit.W3C.Dom.IAttr CreateAttributeNS(string arg0, string arg1)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IAttr>(WObj.createAttributeNS(arg0, arg1));
      }

// Generating method code for createComment
      public virtual NHtmlUnit.W3C.Dom.IComment CreateComment(string arg0)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IComment>(WObj.createComment(arg0));
      }

// Generating method code for createTextNode
      public virtual NHtmlUnit.W3C.Dom.IText CreateTextNode(string arg0)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IText>(WObj.createTextNode(arg0));
      }

// Generating method code for createCDATASection
      public virtual NHtmlUnit.W3C.Dom.ICDATASection CreateCDATASection(string arg0)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.ICDATASection>(WObj.createCDATASection(arg0));
      }

// Generating method code for createDocumentFragment
      public virtual NHtmlUnit.W3C.Dom.IDocumentFragment CreateDocumentFragment()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IDocumentFragment>(WObj.createDocumentFragment());
      }

// Generating method code for createEntityReference
      public virtual NHtmlUnit.W3C.Dom.IEntityReference CreateEntityReference(string arg0)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IEntityReference>(WObj.createEntityReference(arg0));
      }

// Generating method code for createProcessingInstruction
      public virtual NHtmlUnit.W3C.Dom.IProcessingInstruction CreateProcessingInstruction(string arg0, string arg1)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.IProcessingInstruction>(WObj.createProcessingInstruction(arg0, arg1));
      }

// Generating method code for createDomDocumentFragment
      public virtual NHtmlUnit.Html.DomDocumentFragment CreateDomDocumentFragment()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomDocumentFragment>(WObj.createDomDocumentFragment());
      }

// Generating method code for createAttribute
      public virtual NHtmlUnit.Html.DomAttr CreateAttribute(string name)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomAttr>(WObj.createAttribute(name));
      }

// Generating method code for normalizeDocument
      public virtual void NormalizeDocument()
      {
         WObj.normalizeDocument();
      }

   }


}
