// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Background
{
   public partial class JavaScriptStringJob : NHtmlUnit.Javascript.Background.JavaScriptExecutionJob
   {
      static JavaScriptStringJob()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.background.JavaScriptStringJob o) =>
            new JavaScriptStringJob(o));
      }

      public JavaScriptStringJob(com.gargoylesoftware.htmlunit.javascript.background.JavaScriptStringJob wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.background.JavaScriptStringJob WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.background.JavaScriptStringJob)WrappedObject; }
      }

      public JavaScriptStringJob(int initialDelay, java.lang.Integer period, string label, NHtmlUnit.IWebWindow window, string script)
         : this(new com.gargoylesoftware.htmlunit.javascript.background.JavaScriptStringJob(initialDelay, period, label, (com.gargoylesoftware.htmlunit.WebWindow)window.WrappedObject, script)) {}

   }


}
