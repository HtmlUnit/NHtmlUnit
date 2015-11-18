// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Configuration
{
   public partial class AbstractJavaScriptConfiguration : ObjectWrapper
   {
      static AbstractJavaScriptConfiguration()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.configuration.AbstractJavaScriptConfiguration o) =>
            new AbstractJavaScriptConfiguration(o));
      }

      public AbstractJavaScriptConfiguration(com.gargoylesoftware.htmlunit.javascript.configuration.AbstractJavaScriptConfiguration wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.javascript.configuration.AbstractJavaScriptConfiguration WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.configuration.AbstractJavaScriptConfiguration)WrappedObject; }
      }


      public IEnumerable<NHtmlUnit.Javascript.Configuration.ClassConfiguration> All
      {
         get
         {
            return new IterableWrapper<NHtmlUnit.Javascript.Configuration.ClassConfiguration>(
               WObj.getAll());
         }
       }

      public java.util.Map DomJavaScriptMapping
      {
         get
         {
            return WObj.getDomJavaScriptMapping();
         }
      }
// Generating method code for getClassConfiguration
      public virtual NHtmlUnit.Javascript.Configuration.ClassConfiguration GetClassConfiguration(string hostClassName)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Configuration.ClassConfiguration>(WObj.getClassConfiguration(hostClassName));
      }

   }


}
