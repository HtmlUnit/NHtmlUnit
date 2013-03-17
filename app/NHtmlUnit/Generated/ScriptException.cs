// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class ScriptException : ObjectWrapper
   {
      static ScriptException()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.ScriptException o) =>
            new ScriptException(o));
      }

      public ScriptException(com.gargoylesoftware.htmlunit.ScriptException wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.ScriptException WObj
      {
         get { return (com.gargoylesoftware.htmlunit.ScriptException)WrappedObject; }
      }

      public ScriptException(NHtmlUnit.Html.HtmlPage page, System.Exception throwable, string scriptSourceCode)
         : this(new com.gargoylesoftware.htmlunit.ScriptException((com.gargoylesoftware.htmlunit.html.HtmlPage)page.WrappedObject, throwable, scriptSourceCode)) {}

      public ScriptException(NHtmlUnit.Html.HtmlPage page, System.Exception throwable)
         : this(new com.gargoylesoftware.htmlunit.ScriptException((com.gargoylesoftware.htmlunit.html.HtmlPage)page.WrappedObject, throwable)) {}


      public System.String FailingLine
      {
         get
         {
            return WObj.getFailingLine();
         }
      }

      public System.Int32 FailingLineNumber
      {
         get
         {
            return WObj.getFailingLineNumber();
         }
      }

      public System.String ScriptSourceCode
      {
         get
         {
            return WObj.getScriptSourceCode();
         }
      }

      public NHtmlUnit.Html.HtmlPage Page
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlPage>(
               WObj.getPage());
         }
      }

// Generating method code for printScriptStackTrace
      public virtual void PrintScriptStackTrace(java.io.PrintWriter writer)
      {
         WObj.printScriptStackTrace(writer);
      }

   }


}
