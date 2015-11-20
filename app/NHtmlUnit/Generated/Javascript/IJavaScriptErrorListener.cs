// Wrapper for com.gargoylesoftware.htmlunit.javascript.JavaScriptErrorListener
// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit.Javascript
{
   public interface IJavaScriptErrorListener : NHtmlUnit.IObjectWrapper
   {
// Generating method code for malformedScriptURL
      void MalformedScriptURL(NHtmlUnit.InteractivePage ip, string str, java.net.MalformedURLException murle);
// Generating method code for loadScriptError
      void LoadScriptError(NHtmlUnit.InteractivePage ip, java.net.URL url, java.lang.Exception e);
// Generating method code for scriptException
      void ScriptException(NHtmlUnit.InteractivePage ip, NHtmlUnit.ScriptException se);
// Generating method code for timeoutError
      void TimeoutError(NHtmlUnit.InteractivePage ip, System.Int64 l1, System.Int64 l2);

   }
}
