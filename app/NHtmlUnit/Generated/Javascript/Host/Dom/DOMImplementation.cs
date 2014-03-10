// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class DOMImplementation : NHtmlUnit.Javascript.SimpleScriptable
   {
      static DOMImplementation()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.DOMImplementation o) =>
            new DOMImplementation(o));
      }

      public DOMImplementation(com.gargoylesoftware.htmlunit.javascript.host.dom.DOMImplementation wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMImplementation WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.DOMImplementation)WrappedObject; }
      }

      public DOMImplementation()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMImplementation()) {}

// Generating method code for hasFeature
      public virtual bool HasFeature(string feature, string version)
      {
         return WObj.hasFeature(feature, version);
      }

// Generating method code for createDocument
      public virtual NHtmlUnit.Javascript.Host.Xml.XMLDocument CreateDocument(string namespaceURI, string qualifiedName, object doctype)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Xml.XMLDocument>(WObj.createDocument(namespaceURI, qualifiedName, doctype));
      }

   }


}
