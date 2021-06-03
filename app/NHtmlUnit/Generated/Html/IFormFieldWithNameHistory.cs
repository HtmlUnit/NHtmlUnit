// Wrapper for com.gargoylesoftware.htmlunit.html.FormFieldWithNameHistory
// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit.Html
{
   public interface IFormFieldWithNameHistory : NHtmlUnit.IObjectWrapper
   {
      System.String OriginalName  { get; }
      ICollection<System.String> NewNames { get; }

   }
}
