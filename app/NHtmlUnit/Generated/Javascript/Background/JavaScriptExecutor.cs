// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Background
{
   public partial class JavaScriptExecutor : ObjectWrapper
   {
      static JavaScriptExecutor()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.background.JavaScriptExecutor o) =>
            new JavaScriptExecutor(o));
      }

      public JavaScriptExecutor(com.gargoylesoftware.htmlunit.javascript.background.JavaScriptExecutor wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.javascript.background.JavaScriptExecutor WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.background.JavaScriptExecutor)WrappedObject; }
      }

      public JavaScriptExecutor(NHtmlUnit.WebClient webClient)
         : this(new com.gargoylesoftware.htmlunit.javascript.background.JavaScriptExecutor((com.gargoylesoftware.htmlunit.WebClient)webClient.WrappedObject)) {}

// Generating method code for addWindow
      public virtual void AddWindow(NHtmlUnit.IWebWindow newWindow)
      {
         WObj.addWindow((com.gargoylesoftware.htmlunit.WebWindow)newWindow.WrappedObject);
      }

// Generating method code for pumpEventLoop
      public virtual int PumpEventLoop(System.Int64 timeoutMillis)
      {
         return WObj.pumpEventLoop(timeoutMillis);
      }

// Generating method code for shutdown
      public virtual void Shutdown()
      {
         WObj.shutdown();
      }

// Generating method code for run
      public virtual void Run()
      {
         WObj.run();
      }

   }


}
