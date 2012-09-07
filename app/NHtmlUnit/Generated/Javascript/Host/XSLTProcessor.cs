// Generated class v4, don't modify

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

// Generating method code for jsxFunction_importStylesheet
      public virtual void JsxFunction_importStylesheet(NHtmlUnit.Javascript.Host.Node style)
      {
         WObj.jsxFunction_importStylesheet((com.gargoylesoftware.htmlunit.javascript.host.Node)style.WrappedObject);
      }

// Generating method code for jsxFunction_setParameter
      public virtual void JsxFunction_setParameter(string namespaceURI, string localName, object value)
      {
         WObj.jsxFunction_setParameter(namespaceURI, localName, value);
      }

// Generating method code for jsConstructor
      public virtual void JsConstructor()
      {
         WObj.jsConstructor();
      }

// Generating method code for jsxFunction_transformToDocument
      public virtual NHtmlUnit.Javascript.Host.Xml.XMLDocument JsxFunction_transformToDocument(NHtmlUnit.Javascript.Host.Node source)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Xml.XMLDocument>(WObj.jsxFunction_transformToDocument((com.gargoylesoftware.htmlunit.javascript.host.Node)source.WrappedObject));
      }

// Generating method code for jsxFunction_transformToFragment
      public virtual NHtmlUnit.Javascript.Host.DocumentFragment JsxFunction_transformToFragment(NHtmlUnit.Javascript.Host.Node source, object output)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.DocumentFragment>(WObj.jsxFunction_transformToFragment((com.gargoylesoftware.htmlunit.javascript.host.Node)source.WrappedObject, output));
      }

// Generating method code for jsxFunction_getParameter
      public virtual object JsxFunction_getParameter(string namespaceURI, string localName)
      {
         return WObj.jsxFunction_getParameter(namespaceURI, localName);
      }

// Generating method code for jsxSet_input
      public virtual void JsxSet_input(NHtmlUnit.Javascript.Host.Node input)
      {
         WObj.jsxSet_input((com.gargoylesoftware.htmlunit.javascript.host.Node)input.WrappedObject);
      }

// Generating method code for jsxGet_input
      public virtual NHtmlUnit.Javascript.Host.Node JsxGet_input()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxGet_input());
      }

// Generating method code for jsxSet_output
      public virtual void JsxSet_output(object output)
      {
         WObj.jsxSet_output(output);
      }

// Generating method code for jsxGet_output
      public virtual object JsxGet_output()
      {
         return WObj.jsxGet_output();
      }

// Generating method code for jsxFunction_addParameter
      public virtual void JsxFunction_addParameter(string baseName, object parameter, object namespaceURI)
      {
         WObj.jsxFunction_addParameter(baseName, parameter, namespaceURI);
      }

// Generating method code for jsxFunction_transform
      public virtual void JsxFunction_transform()
      {
         WObj.jsxFunction_transform();
      }

   }


}
