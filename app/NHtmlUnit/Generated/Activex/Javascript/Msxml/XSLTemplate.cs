// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class XSLTemplate : NHtmlUnit.Activex.Javascript.Msxml.MSXMLScriptable
   {
      static XSLTemplate()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XSLTemplate o) =>
            new XSLTemplate(o));
      }

      public XSLTemplate(com.gargoylesoftware.htmlunit.activex.javascript.msxml.XSLTemplate wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XSLTemplate WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.XSLTemplate)WrappedObject; }
      }

      public XSLTemplate()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XSLTemplate()) {}


      public NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode Stylesheet
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode>(
               WObj.getStylesheet());
         }
         set
         {
            WObj.setStylesheet((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNode)value.WrappedObject);
         }

      }

// Generating method code for createProcessor
      public virtual NHtmlUnit.Activex.Javascript.Msxml.XSLProcessor CreateProcessor()
      {
         var arg = WObj.createProcessor();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Activex.Javascript.Msxml.XSLProcessor>(arg);
      }

   }


}
