// Generated class v2.50.0.0, don't modify

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
      public virtual NHtmlUnit.Javascript.Host.Xml.XMLDocument CreateDocument(string namespaceURI, string qualifiedName, NHtmlUnit.Javascript.Host.Dom.DocumentType doctype)
      {
         var arg = WObj.createDocument(namespaceURI, qualifiedName, (com.gargoylesoftware.htmlunit.javascript.host.dom.DocumentType)doctype.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Xml.XMLDocument>(arg);
      }

// Generating method code for createHTMLDocument
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLDocument CreateHTMLDocument(object titleObj)
      {
         var arg = WObj.createHTMLDocument(titleObj);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLDocument>(arg);
      }

   }


}
