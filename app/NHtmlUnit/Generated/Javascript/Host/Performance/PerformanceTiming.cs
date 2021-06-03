// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Performance
{
   public partial class PerformanceTiming : NHtmlUnit.Javascript.SimpleScriptable
   {
      static PerformanceTiming()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceTiming o) =>
            new PerformanceTiming(o));
      }

      public PerformanceTiming(com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceTiming wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceTiming WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceTiming)WrappedObject; }
      }

      public PerformanceTiming()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceTiming()) {}


      public System.Int64 DomainLookupStart
      {
         get
         {
            return WObj.getDomainLookupStart();
         }
      }

      public System.Int64 DomainLookupEnd
      {
         get
         {
            return WObj.getDomainLookupEnd();
         }
      }

      public System.Int64 ConnectStart
      {
         get
         {
            return WObj.getConnectStart();
         }
      }

      public System.Int64 ConnectEnd
      {
         get
         {
            return WObj.getConnectEnd();
         }
      }

      public System.Int64 ResponseStart
      {
         get
         {
            return WObj.getResponseStart();
         }
      }

      public System.Int64 ResponseEnd
      {
         get
         {
            return WObj.getResponseEnd();
         }
      }

      public System.Int64 SecureConnectionStart
      {
         get
         {
            return WObj.getSecureConnectionStart();
         }
      }

      public System.Int64 UnloadEventStart
      {
         get
         {
            return WObj.getUnloadEventStart();
         }
      }

      public System.Int64 UnloadEventEnd
      {
         get
         {
            return WObj.getUnloadEventEnd();
         }
      }

      public System.Int64 RedirectStart
      {
         get
         {
            return WObj.getRedirectStart();
         }
      }

      public System.Int64 RedirectEnd
      {
         get
         {
            return WObj.getRedirectEnd();
         }
      }

      public System.Int64 DomContentLoadedEventStart
      {
         get
         {
            return WObj.getDomContentLoadedEventStart();
         }
      }

      public System.Int64 DomLoading
      {
         get
         {
            return WObj.getDomLoading();
         }
      }

      public System.Int64 DomInteractive
      {
         get
         {
            return WObj.getDomInteractive();
         }
      }

      public System.Int64 DomContentLoadedEventEnd
      {
         get
         {
            return WObj.getDomContentLoadedEventEnd();
         }
      }

      public System.Int64 DomComplete
      {
         get
         {
            return WObj.getDomComplete();
         }
      }

      public System.Int64 LoadEventStart
      {
         get
         {
            return WObj.getLoadEventStart();
         }
      }

      public System.Int64 LoadEventEnd
      {
         get
         {
            return WObj.getLoadEventEnd();
         }
      }

      public System.Int64 NavigationStart
      {
         get
         {
            return WObj.getNavigationStart();
         }
      }

      public System.Int64 FetchStart
      {
         get
         {
            return WObj.getFetchStart();
         }
      }
   }


}
