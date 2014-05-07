// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class XSLTProcessor : NHtmlUnit.Javascript.SimpleScriptable
   {
      static XSLTProcessor()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.XSLTProcessor o) =>
            new XSLTProcessor(o));
      }

      public XSLTProcessor(com.gargoylesoftware.htmlunit.javascript.host.XSLTProcessor wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.XSLTProcessor WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.XSLTProcessor)WrappedObject; }
      }

      public XSLTProcessor()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.XSLTProcessor()) {}


      public NHtmlUnit.Javascript.Host.Node Input
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(
               WObj.getInput());
         }
         set
         {
            WObj.setInput((com.gargoylesoftware.htmlunit.javascript.host.Node)value.WrappedObject);
         }

      }


      public System.Object Output
      {
         get
         {
            return WObj.getOutput();
         }
         set
         {
            WObj.setOutput(value);
         }

      }
// Generating method code for importStylesheet
      public virtual void ImportStylesheet(NHtmlUnit.Javascript.Host.Node style)
      {
         WObj.importStylesheet((com.gargoylesoftware.htmlunit.javascript.host.Node)style.WrappedObject);
      }

// Generating method code for setParameter
      public virtual void SetParameter(string namespaceURI, string localName, object value)
      {
         WObj.setParameter(namespaceURI, localName, value);
      }

// Generating method code for jsConstructor
      public virtual void JsConstructor()
      {
         WObj.jsConstructor();
      }

// Generating method code for transformToDocument
      public virtual NHtmlUnit.Javascript.Host.Xml.XMLDocument TransformToDocument(NHtmlUnit.Javascript.Host.Node source)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Xml.XMLDocument>(WObj.transformToDocument((com.gargoylesoftware.htmlunit.javascript.host.Node)source.WrappedObject));
      }

// Generating method code for transformToFragment
      public virtual NHtmlUnit.Javascript.Host.DocumentFragment TransformToFragment(NHtmlUnit.Javascript.Host.Node source, object output)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.DocumentFragment>(WObj.transformToFragment((com.gargoylesoftware.htmlunit.javascript.host.Node)source.WrappedObject, output));
      }

// Generating method code for getParameter
      public virtual object GetParameter(string namespaceURI, string localName)
      {
         return WObj.getParameter(namespaceURI, localName);
      }

// Generating method code for addParameter
      public virtual void AddParameter(string baseName, object parameter, object namespaceURI)
      {
         WObj.addParameter(baseName, parameter, namespaceURI);
      }

// Generating method code for transform
      public virtual void Transform()
      {
         WObj.transform();
      }

   }


}
