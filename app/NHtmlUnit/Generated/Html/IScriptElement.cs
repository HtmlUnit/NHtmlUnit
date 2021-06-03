// Wrapper for com.gargoylesoftware.htmlunit.html.ScriptElement
// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit.Html
{
   public interface IScriptElement : NHtmlUnit.IObjectWrapper
   {
      System.String SrcAttribute  { get; }
      System.String CharsetAttribute  { get; }
// Generating method code for isExecuted
      bool IsExecuted();
// Generating method code for isDeferred
      bool IsDeferred();

   }
}
