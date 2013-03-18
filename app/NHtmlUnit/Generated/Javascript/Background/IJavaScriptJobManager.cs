// Wrapper for com.gargoylesoftware.htmlunit.javascript.background.JavaScriptJobManager
// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit.Javascript.Background
{
   public interface IJavaScriptJobManager : NHtmlUnit.IObjectWrapper
   {
      System.Int32 JobCount  { get; }
      NHtmlUnit.Javascript.Background.IJavaScriptJob EarliestJob  { get; }
// Generating method code for waitForJobs
      int WaitForJobs(System.Int64 l);
// Generating method code for waitForJobsStartingBefore
      int WaitForJobsStartingBefore(System.Int64 l);
// Generating method code for removeAllJobs
      void RemoveAllJobs();
// Generating method code for shutdown
      void Shutdown();
// Generating method code for addJob
      int AddJob(NHtmlUnit.Javascript.Background.IJavaScriptJob jsj, NHtmlUnit.IPage p);
// Generating method code for removeJob
      void RemoveJob(int i);
// Generating method code for stopJob
      void StopJob(int i);
// Generating method code for runSingleJob
      bool RunSingleJob(NHtmlUnit.Javascript.Background.IJavaScriptJob jsj);

   }
}
