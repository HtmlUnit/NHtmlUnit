// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Configuration
{
   public partial class JavaScriptConfiguration : NHtmlUnit.Javascript.Configuration.AbstractJavaScriptConfiguration
   {
      static JavaScriptConfiguration()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.configuration.JavaScriptConfiguration o) =>
            new JavaScriptConfiguration(o));
      }

      public JavaScriptConfiguration(com.gargoylesoftware.htmlunit.javascript.configuration.JavaScriptConfiguration wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.configuration.JavaScriptConfiguration WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.configuration.JavaScriptConfiguration)WrappedObject; }
      }

   }


}
