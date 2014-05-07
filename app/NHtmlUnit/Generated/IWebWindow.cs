// Wrapper for com.gargoylesoftware.htmlunit.WebWindow
// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit
{
   public interface IWebWindow : NHtmlUnit.IObjectWrapper
   {
      System.Object ScriptObject { get; set; }
      NHtmlUnit.WebClient WebClient  { get; }
      NHtmlUnit.IPage EnclosedPage { get; set; }
      NHtmlUnit.Javascript.Background.IJavaScriptJobManager JobManager  { get; }
      System.String Name { get; set; }
      NHtmlUnit.IWebWindow ParentWindow  { get; }
      NHtmlUnit.IWebWindow TopWindow  { get; }
      NHtmlUnit.History History  { get; }
      System.Int32 InnerWidth { get; set; }
      System.Int32 OuterWidth { get; set; }
      System.Int32 InnerHeight { get; set; }
      System.Int32 OuterHeight { get; set; }
// Generating method code for isClosed
      bool IsClosed();

   }
}
