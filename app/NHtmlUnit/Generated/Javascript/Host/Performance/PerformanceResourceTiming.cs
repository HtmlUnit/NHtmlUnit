// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Performance
{
   public partial class PerformanceResourceTiming : NHtmlUnit.Javascript.Host.Performance.PerformanceEntry
   {
      static PerformanceResourceTiming()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceResourceTiming o) =>
            new PerformanceResourceTiming(o));
      }

      public PerformanceResourceTiming(com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceResourceTiming wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceResourceTiming WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceResourceTiming)WrappedObject; }
      }

      public PerformanceResourceTiming()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceResourceTiming()) {}

   }


}
