// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class DomDocumentType : NHtmlUnit.Html.DomNode, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IDocumentType
   {
      static DomDocumentType()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.DomDocumentType o) =>
            new DomDocumentType(o));
      }

      public DomDocumentType(com.gargoylesoftware.htmlunit.html.DomDocumentType wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.DomDocumentType WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.DomDocumentType)WrappedObject; }
      }

      public DomDocumentType(NHtmlUnit.SgmlPage page, string name, string publicId, string systemId)
         : this(new com.gargoylesoftware.htmlunit.html.DomDocumentType((com.gargoylesoftware.htmlunit.SgmlPage)page.WrappedObject, name, publicId, systemId)) {}


      public NHtmlUnit.W3C.Dom.INamedNodeMap Entities
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.INamedNodeMap>(
               WObj.getEntities());
         }
      }


      public System.String InternalSubset
      {
         get
         {
            return WObj.getInternalSubset();
         }
      }

      public System.String Name
      {
         get
         {
            return WObj.getName();
         }
      }

      public NHtmlUnit.W3C.Dom.INamedNodeMap Notations
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.INamedNodeMap>(
               WObj.getNotations());
         }
      }


      public System.String PublicId
      {
         get
         {
            return WObj.getPublicId();
         }
      }

      public System.String SystemId
      {
         get
         {
            return WObj.getSystemId();
         }
      }
   }


}
