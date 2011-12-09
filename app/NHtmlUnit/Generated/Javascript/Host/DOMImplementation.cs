// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class DOMImplementation : NHtmlUnit.Javascript.SimpleScriptable
   {
      static DOMImplementation()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.DOMImplementation o) =>
            new DOMImplementation(o));
      }

      public DOMImplementation(com.gargoylesoftware.htmlunit.javascript.host.DOMImplementation wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.DOMImplementation WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.DOMImplementation)WrappedObject; }
      }

      public DOMImplementation()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.DOMImplementation()) {}

// Generating method code for jsxFunction_hasFeature
      public virtual bool JsxFunction_hasFeature(string feature, string version)
      {
         return WObj.jsxFunction_hasFeature(feature, version);
      }

// Generating method code for jsxFunction_createDocument
      public virtual NHtmlUnit.Javascript.Host.Xml.XMLDocument JsxFunction_createDocument(string namespaceURI, string qualifiedName, object doctype)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Xml.XMLDocument>(WObj.jsxFunction_createDocument(namespaceURI, qualifiedName, doctype));
      }

   }


}
