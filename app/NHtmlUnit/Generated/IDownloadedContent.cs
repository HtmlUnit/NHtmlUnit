// Wrapper for com.gargoylesoftware.htmlunit.DownloadedContent
// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit
{
   public interface IDownloadedContent : NHtmlUnit.IObjectWrapper
   {
      java.io.InputStream InputStream  { get; }
// Generating method code for cleanUp
      void CleanUp();
// Generating method code for isEmpty
      bool IsEmpty();

   }
}
