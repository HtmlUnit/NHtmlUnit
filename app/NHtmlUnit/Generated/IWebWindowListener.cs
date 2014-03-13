// Wrapper for com.gargoylesoftware.htmlunit.WebWindowListener
// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit
{
   public interface IWebWindowListener : NHtmlUnit.IObjectWrapper
   {
// Generating method code for webWindowContentChanged
      void WebWindowContentChanged(NHtmlUnit.WebWindowEvent wwe);
// Generating method code for webWindowOpened
      void WebWindowOpened(NHtmlUnit.WebWindowEvent wwe);
// Generating method code for webWindowClosed
      void WebWindowClosed(NHtmlUnit.WebWindowEvent wwe);

   }
}
