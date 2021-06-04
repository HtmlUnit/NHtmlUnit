// Wrapper for com.gargoylesoftware.htmlunit.javascript.AbstractJavaScriptEngine
// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit.Javascript
{
   public interface IAbstractJavaScriptEngine : NHtmlUnit.IObjectWrapper
   {
      NHtmlUnit.Javascript.Configuration.JavaScriptConfiguration JavaScriptConfiguration  { get; }
      System.Int64 JavaScriptTimeout { get; set; }
// Generating method code for holdPosponedActions
      void HoldPosponedActions();
// Generating method code for processPostponedActions
      void ProcessPostponedActions();
// Generating method code for isScriptRunning
      bool IsScriptRunning();
// Generating method code for addPostponedAction
      void AddPostponedAction(NHtmlUnit.Javascript.PostponedAction pa);
// Generating method code for execute
      object Execute(NHtmlUnit.Html.HtmlPage hp, string str1, string str2, int i);
// Generating method code for execute
      object Execute(NHtmlUnit.Html.HtmlPage hp, object obj);
// Generating method code for compile
      object Compile(NHtmlUnit.Html.HtmlPage hp, string str1, string str2, int i);
// Generating method code for registerWindowAndMaybeStartEventLoop
      void RegisterWindowAndMaybeStartEventLoop(NHtmlUnit.IWebWindow ww);
// Generating method code for initialize
      void Initialize(NHtmlUnit.IWebWindow ww, NHtmlUnit.IPage p);
// Generating method code for shutdown
      void Shutdown();

   }
}
