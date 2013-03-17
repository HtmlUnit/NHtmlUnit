// Wrapper for com.gargoylesoftware.htmlunit.DownloadedContent
// Generated class v5, don't modify

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

   }
}
