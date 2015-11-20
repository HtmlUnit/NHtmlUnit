// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class DocumentType : NHtmlUnit.Javascript.Host.Dom.Node
   {
      static DocumentType()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.DocumentType o) =>
            new DocumentType(o));
      }

      public DocumentType(com.gargoylesoftware.htmlunit.javascript.host.dom.DocumentType wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.DocumentType WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.DocumentType)WrappedObject; }
      }

      public DocumentType()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DocumentType()) {}


      public System.String Name
      {
         get
         {
            return WObj.getName();
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

      public System.String InternalSubset
      {
         get
         {
            return WObj.getInternalSubset();
         }
      }

      public System.Object Entities
      {
         get
         {
            return WObj.getEntities();
         }
      }

      public System.Object Notations
      {
         get
         {
            return WObj.getNotations();
         }
      }
   }


}
