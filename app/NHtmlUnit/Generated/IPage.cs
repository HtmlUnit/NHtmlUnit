// Wrapper for com.gargoylesoftware.htmlunit.Page
// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit
{
   public interface IPage : NHtmlUnit.IObjectWrapper
   {
      NHtmlUnit.WebResponse WebResponse  { get; }
      NHtmlUnit.IWebWindow EnclosingWindow  { get; }
      java.net.URL Url  { get; }
// Generating method code for initialize
      void Initialize();
// Generating method code for cleanUp
      void CleanUp();
// Generating method code for isHtmlPage
      bool IsHtmlPage();

   }
}
