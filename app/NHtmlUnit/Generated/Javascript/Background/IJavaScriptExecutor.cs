// Wrapper for com.gargoylesoftware.htmlunit.javascript.background.JavaScriptExecutor
// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit.Javascript.Background
{
   public interface IJavaScriptExecutor : NHtmlUnit.IObjectWrapper
   {
// Generating method code for addWindow
      void AddWindow(NHtmlUnit.IWebWindow ww);
// Generating method code for shutdown
      void Shutdown();
// Generating method code for pumpEventLoop
      int PumpEventLoop(System.Int64 l);

   }
}
