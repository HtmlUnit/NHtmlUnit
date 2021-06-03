// Wrapper for com.gargoylesoftware.htmlunit.WebConnection
// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit
{
   public interface IWebConnection : NHtmlUnit.IObjectWrapper
   {
// Generating method code for getResponse
      NHtmlUnit.WebResponse GetResponse(NHtmlUnit.WebRequest wr);
// Generating method code for close
      void Close();

   }
}
