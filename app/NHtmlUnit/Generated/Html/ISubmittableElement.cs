// Wrapper for com.gargoylesoftware.htmlunit.html.SubmittableElement
// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit.Html
{
   public interface ISubmittableElement : NHtmlUnit.IObjectWrapper
   {
      System.String DefaultValue { get; set; }
      com.gargoylesoftware.htmlunit.util.NameValuePair[] SubmitKeyValuePairs  { get; }
// Generating method code for isDefaultChecked
      bool IsDefaultChecked();
// Generating method code for reset
      void Reset();

   }
}
