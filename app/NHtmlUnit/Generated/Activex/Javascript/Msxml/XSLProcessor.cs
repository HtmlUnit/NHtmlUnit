// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class XSLProcessor : NHtmlUnit.Activex.Javascript.Msxml.MSXMLScriptable
   {
      static XSLProcessor()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XSLProcessor o) =>
            new XSLProcessor(o));
      }

      public XSLProcessor(com.gargoylesoftware.htmlunit.activex.javascript.msxml.XSLProcessor wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XSLProcessor WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.XSLProcessor)WrappedObject; }
      }

      public XSLProcessor()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XSLProcessor()) {}


      public NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode Input
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode>(
               WObj.getInput());
         }
         set
         {
            WObj.setInput((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNode)value.WrappedObject);
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

// Generating method code for importStylesheet
      public virtual void ImportStylesheet(NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode style)
      {
         WObj.importStylesheet((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNode)style.WrappedObject);
      }

   }


}
