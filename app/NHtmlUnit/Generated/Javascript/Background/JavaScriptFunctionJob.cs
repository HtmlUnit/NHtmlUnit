// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Background
{
   public partial class JavaScriptFunctionJob : NHtmlUnit.Javascript.Background.JavaScriptExecutionJob
   {
      static JavaScriptFunctionJob()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.background.JavaScriptFunctionJob o) =>
            new JavaScriptFunctionJob(o));
      }

      public JavaScriptFunctionJob(com.gargoylesoftware.htmlunit.javascript.background.JavaScriptFunctionJob wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.background.JavaScriptFunctionJob WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.background.JavaScriptFunctionJob)WrappedObject; }
      }

      public JavaScriptFunctionJob(int initialDelay, java.lang.Integer period, string label, NHtmlUnit.IWebWindow window, net.sourceforge.htmlunit.corejs.javascript.Function function)
         : this(new com.gargoylesoftware.htmlunit.javascript.background.JavaScriptFunctionJob(initialDelay, period, label, (com.gargoylesoftware.htmlunit.WebWindow)window.WrappedObject, function)) {}

   }


}
