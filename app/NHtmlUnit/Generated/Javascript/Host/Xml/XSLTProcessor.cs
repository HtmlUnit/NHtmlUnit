// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Xml
{
   public partial class XSLTProcessor : NHtmlUnit.Javascript.SimpleScriptable
   {
      static XSLTProcessor()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.xml.XSLTProcessor o) =>
            new XSLTProcessor(o));
      }

      public XSLTProcessor(com.gargoylesoftware.htmlunit.javascript.host.xml.XSLTProcessor wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.xml.XSLTProcessor WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.xml.XSLTProcessor)WrappedObject; }
      }

      public XSLTProcessor()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.xml.XSLTProcessor()) {}

// Generating method code for importStylesheet
      public virtual void ImportStylesheet(NHtmlUnit.Javascript.Host.Dom.Node style)
      {
         WObj.importStylesheet((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)style.WrappedObject);
      }

// Generating method code for transformToDocument
      public virtual NHtmlUnit.Javascript.Host.Xml.XMLDocument TransformToDocument(NHtmlUnit.Javascript.Host.Dom.Node source)
      {
         var arg = WObj.transformToDocument((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)source.WrappedObject);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Xml.XMLDocument>(arg);
      }

// Generating method code for transformToFragment
      public virtual NHtmlUnit.Javascript.Host.Dom.DocumentFragment TransformToFragment(NHtmlUnit.Javascript.Host.Dom.Node source, object output)
      {
         var arg = WObj.transformToFragment((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)source.WrappedObject, output);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.DocumentFragment>(arg);
      }

// Generating method code for setParameter
      public virtual void SetParameter(string namespaceURI, string localName, object value)
      {
         WObj.setParameter(namespaceURI, localName, value);
      }

// Generating method code for getParameter
      public virtual object GetParameter(string namespaceURI, string localName)
      {
         var arg = WObj.getParameter(namespaceURI, localName);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

   }


}
