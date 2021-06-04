// Wrapper for com.gargoylesoftware.htmlunit.javascript.background.JavaScriptJob
// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit.Javascript.Background
{
   public interface IJavaScriptJob : NHtmlUnit.IObjectWrapper
   {
      java.lang.Integer Id { get; set; }
      System.Int64 TargetExecutionTime { get; set; }
      java.lang.Integer Period  { get; }
// Generating method code for isPeriodic
      bool IsPeriodic();
// Generating method code for isExecuteAsap
      bool IsExecuteAsap();

   }
}
