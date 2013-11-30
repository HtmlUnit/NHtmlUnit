// Wrapper for com.gargoylesoftware.htmlunit.javascript.JavaScriptErrorListener
// Generated class v2.13.0.0, don't modify

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
      void MalformedScriptURL(NHtmlUnit.Html.HtmlPage hp, string str, java.net.MalformedURLException murle);
// Generating method code for loadScriptError
      void LoadScriptError(NHtmlUnit.Html.HtmlPage hp, java.net.URL url, java.lang.Exception e);
// Generating method code for timeoutError
      void TimeoutError(NHtmlUnit.Html.HtmlPage hp, System.Int64 l1, System.Int64 l2);
// Generating method code for scriptException
      void ScriptException(NHtmlUnit.Html.HtmlPage hp, NHtmlUnit.ScriptException se);

   }
}
