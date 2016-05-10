// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript
{
   public partial class JavaScriptEngine : ObjectWrapper
   {
      static JavaScriptEngine()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.JavaScriptEngine o) =>
            new JavaScriptEngine(o));
      }

      public JavaScriptEngine(com.gargoylesoftware.htmlunit.javascript.JavaScriptEngine wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.javascript.JavaScriptEngine WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.JavaScriptEngine)WrappedObject; }
      }

      public JavaScriptEngine(NHtmlUnit.WebClient webClient)
         : this(new com.gargoylesoftware.htmlunit.javascript.JavaScriptEngine((com.gargoylesoftware.htmlunit.WebClient)webClient.WrappedObject)) {}


      public NHtmlUnit.Javascript.HtmlUnitContextFactory ContextFactory
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.HtmlUnitContextFactory>(
               WObj.getContextFactory());
         }
      }


      public NHtmlUnit.Javascript.Configuration.JavaScriptConfiguration JavaScriptConfiguration
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Configuration.JavaScriptConfiguration>(
               WObj.getJavaScriptConfiguration());
         }
      }


      public NHtmlUnit.WebClient WebClient
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.WebClient>(
               WObj.getWebClient());
         }
      }


      public NHtmlUnit.Javascript.Background.IJavaScriptExecutor JavaScriptExecutor
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Background.IJavaScriptExecutor>(
               WObj.getJavaScriptExecutor());
         }
      }


      public System.Int64 JavaScriptTimeout
      {
         get
         {
            return WObj.getJavaScriptTimeout();
         }
         set
         {
            WObj.setJavaScriptTimeout(value);
         }

      }
// Generating method code for getJavaScriptClass
      public virtual java.lang.Class GetJavaScriptClass(java.lang.Class c)
      {
         return WObj.getJavaScriptClass(c);
      }

// Generating method code for callFunction
      public virtual object CallFunction(NHtmlUnit.InteractivePage page, net.sourceforge.htmlunit.corejs.javascript.Function function, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, net.sourceforge.htmlunit.corejs.javascript.Scriptable thisObject, System.Object[] args)
      {
         var arg = WObj.callFunction((com.gargoylesoftware.htmlunit.InteractivePage)page.WrappedObject, function, scope, thisObject, args);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for holdPosponedActions
      public virtual void HoldPosponedActions()
      {
         WObj.holdPosponedActions();
      }

// Generating method code for processPostponedActions
      public virtual void ProcessPostponedActions()
      {
         WObj.processPostponedActions();
      }

// Generating method code for isScriptRunning
      public virtual bool IsScriptRunning()
      {
         return WObj.isScriptRunning();
      }

// Generating method code for addPostponedAction
      public virtual void AddPostponedAction(NHtmlUnit.Javascript.PostponedAction action)
      {
         WObj.addPostponedAction((com.gargoylesoftware.htmlunit.javascript.PostponedAction)action.WrappedObject);
      }

// Generating method code for callFunction
      public virtual object CallFunction(NHtmlUnit.InteractivePage page, net.sourceforge.htmlunit.corejs.javascript.Function javaScriptFunction, net.sourceforge.htmlunit.corejs.javascript.Scriptable thisObject, System.Object[] args, NHtmlUnit.Html.DomNode node)
      {
         var arg = WObj.callFunction((com.gargoylesoftware.htmlunit.InteractivePage)page.WrappedObject, javaScriptFunction, thisObject, args, (com.gargoylesoftware.htmlunit.html.DomNode)node.WrappedObject);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for execute
      public virtual object Execute(NHtmlUnit.InteractivePage page, string sourceCode, string sourceName, int startLine)
      {
         var arg = WObj.execute((com.gargoylesoftware.htmlunit.InteractivePage)page.WrappedObject, sourceCode, sourceName, startLine);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for execute
      public virtual object Execute(NHtmlUnit.InteractivePage page, net.sourceforge.htmlunit.corejs.javascript.Script script)
      {
         var arg = WObj.execute((com.gargoylesoftware.htmlunit.InteractivePage)page.WrappedObject, script);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for compile
      public virtual net.sourceforge.htmlunit.corejs.javascript.Script Compile(NHtmlUnit.InteractivePage page, string sourceCode, string sourceName, int startLine)
      {
         return WObj.compile((com.gargoylesoftware.htmlunit.InteractivePage)page.WrappedObject, sourceCode, sourceName, startLine);
      }

// Generating method code for definePropertiesInStandardsMode
      public virtual void DefinePropertiesInStandardsMode(NHtmlUnit.Html.HtmlPage page)
      {
         WObj.definePropertiesInStandardsMode((com.gargoylesoftware.htmlunit.html.HtmlPage)page.WrappedObject);
      }

// Generating method code for compile
      public virtual net.sourceforge.htmlunit.corejs.javascript.Script Compile(NHtmlUnit.InteractivePage owningPage, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, string sourceCode, string sourceName, int startLine)
      {
         return WObj.compile((com.gargoylesoftware.htmlunit.InteractivePage)owningPage.WrappedObject, scope, sourceCode, sourceName, startLine);
      }

// Generating method code for execute
      public virtual object Execute(NHtmlUnit.InteractivePage page, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, net.sourceforge.htmlunit.corejs.javascript.Script script)
      {
         var arg = WObj.execute((com.gargoylesoftware.htmlunit.InteractivePage)page.WrappedObject, scope, script);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for initialize
      public virtual void Initialize(NHtmlUnit.IWebWindow webWindow)
      {
         WObj.initialize((com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject);
      }

// Generating method code for registerWindowAndMaybeStartEventLoop
      public virtual void RegisterWindowAndMaybeStartEventLoop(NHtmlUnit.IWebWindow webWindow)
      {
         WObj.registerWindowAndMaybeStartEventLoop((com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject);
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

   }


}
