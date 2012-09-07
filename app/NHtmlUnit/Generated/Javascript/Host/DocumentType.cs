// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class DocumentType : NHtmlUnit.Javascript.Host.Node
   {
      static DocumentType()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.DocumentType o) =>
            new DocumentType(o));
      }

      public DocumentType(com.gargoylesoftware.htmlunit.javascript.host.DocumentType wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.DocumentType WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.DocumentType)WrappedObject; }
      }

      public DocumentType()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.DocumentType()) {}

// Generating method code for jsxGet_name
      public virtual string JsxGet_name()
      {
         return WObj.jsxGet_name();
      }

// Generating method code for jsxGet_publicId
      public virtual string JsxGet_publicId()
      {
         return WObj.jsxGet_publicId();
      }

// Generating method code for jsxGet_systemId
      public virtual string JsxGet_systemId()
      {
         return WObj.jsxGet_systemId();
      }

// Generating method code for jsxGet_internalSubset
      public virtual string JsxGet_internalSubset()
      {
         return WObj.jsxGet_internalSubset();
      }

// Generating method code for jsxGet_entities
      public virtual object JsxGet_entities()
      {
         return WObj.jsxGet_entities();
      }

// Generating method code for jsxGet_notations
      public virtual object JsxGet_notations()
      {
         return WObj.jsxGet_notations();
      }

   }


}
