// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Performance
{
   public partial class PerformanceNavigationTiming : NHtmlUnit.Javascript.Host.Performance.PerformanceResourceTiming
   {
      static PerformanceNavigationTiming()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceNavigationTiming o) =>
            new PerformanceNavigationTiming(o));
      }

      public PerformanceNavigationTiming(com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceNavigationTiming wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceNavigationTiming WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceNavigationTiming)WrappedObject; }
      }

      public PerformanceNavigationTiming()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceNavigationTiming()) {}

   }


}
