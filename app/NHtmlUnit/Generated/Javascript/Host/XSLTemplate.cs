// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class XSLTemplate : NHtmlUnit.Javascript.SimpleScriptable
   {
      static XSLTemplate()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.XSLTemplate o) =>
            new XSLTemplate(o));
      }

      public XSLTemplate(com.gargoylesoftware.htmlunit.javascript.host.XSLTemplate wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.XSLTemplate WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.XSLTemplate)WrappedObject; }
      }

      public XSLTemplate()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.XSLTemplate()) {}

// Generating method code for jsxSet_stylesheet
      public virtual void JsxSet_stylesheet(NHtmlUnit.Javascript.Host.Node node)
      {
         WObj.jsxSet_stylesheet((com.gargoylesoftware.htmlunit.javascript.host.Node)node.WrappedObject);
      }

// Generating method code for jsxGet_stylesheet
      public virtual NHtmlUnit.Javascript.Host.Node JsxGet_stylesheet()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxGet_stylesheet());
      }

// Generating method code for jsxFunction_createProcessor
      public virtual NHtmlUnit.Javascript.Host.XSLTProcessor JsxFunction_createProcessor()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.XSLTProcessor>(WObj.jsxFunction_createProcessor());
      }

   }


}
