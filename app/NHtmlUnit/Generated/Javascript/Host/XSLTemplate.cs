// Generated class v2.13, don't modify

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


      public NHtmlUnit.Javascript.Host.Node Stylesheet
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(
               WObj.getStylesheet());
         }
         set
         {
            WObj.setStylesheet((com.gargoylesoftware.htmlunit.javascript.host.Node)value.WrappedObject);
         }

      }

// Generating method code for createProcessor
      public virtual NHtmlUnit.Javascript.Host.XSLTProcessor CreateProcessor()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.XSLTProcessor>(WObj.createProcessor());
      }

   }


}
