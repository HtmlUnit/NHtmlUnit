// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Configuration
{
   public partial class JavaScriptConfiguration : ObjectWrapper
   {
      static JavaScriptConfiguration()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.configuration.JavaScriptConfiguration o) =>
            new JavaScriptConfiguration(o));
      }

      public JavaScriptConfiguration(com.gargoylesoftware.htmlunit.javascript.configuration.JavaScriptConfiguration wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.javascript.configuration.JavaScriptConfiguration WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.configuration.JavaScriptConfiguration)WrappedObject; }
      }


      public java.util.Map DomJavaScriptMapping
      {
         get
         {
            return WObj.getDomJavaScriptMapping();
         }
      }

      public IEnumerable<NHtmlUnit.Javascript.Configuration.ClassConfiguration> All
      {
         get
         {
            return new IterableWrapper<NHtmlUnit.Javascript.Configuration.ClassConfiguration>(
               WObj.getAll());
         }
       }
// Generating method code for getClassConfiguration
      public virtual NHtmlUnit.Javascript.Configuration.ClassConfiguration GetClassConfiguration(string hostClassName)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Configuration.ClassConfiguration>(WObj.getClassConfiguration(hostClassName));
      }

   }


}
