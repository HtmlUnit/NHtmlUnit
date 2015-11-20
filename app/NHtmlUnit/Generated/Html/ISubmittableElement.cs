// Wrapper for com.gargoylesoftware.htmlunit.html.SubmittableElement
// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit.Html
{
   public interface ISubmittableElement : NHtmlUnit.IObjectWrapper
   {
      com.gargoylesoftware.htmlunit.util.NameValuePair[] SubmitKeyValuePairs  { get; }
      System.String DefaultValue { get; set; }
// Generating method code for reset
      void Reset();
// Generating method code for isDefaultChecked
      bool IsDefaultChecked();

   }
}
