// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Background
{
   public partial class JavaScriptExecutionJob : NHtmlUnit.Javascript.Background.JavaScriptJob
   {
      static JavaScriptExecutionJob()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.background.JavaScriptExecutionJob o) =>
            new JavaScriptExecutionJob(o));
      }

      public JavaScriptExecutionJob(com.gargoylesoftware.htmlunit.javascript.background.JavaScriptExecutionJob wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.background.JavaScriptExecutionJob WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.background.JavaScriptExecutionJob)WrappedObject; }
      }

   }


}
