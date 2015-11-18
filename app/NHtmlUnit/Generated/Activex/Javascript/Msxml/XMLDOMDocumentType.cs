// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class XMLDOMDocumentType : NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode
   {
      static XMLDOMDocumentType()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMDocumentType o) =>
            new XMLDOMDocumentType(o));
      }

      public XMLDOMDocumentType(com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMDocumentType wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMDocumentType WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMDocumentType)WrappedObject; }
      }

      public XMLDOMDocumentType()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMDocumentType()) {}


      public System.String Name
      {
         get
         {
            return WObj.getName();
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
