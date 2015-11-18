// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Performance
{
   public partial class PerformanceMeasure : NHtmlUnit.Javascript.Host.Performance.PerformanceEntry
   {
      static PerformanceMeasure()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceMeasure o) =>
            new PerformanceMeasure(o));
      }

      public PerformanceMeasure(com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceMeasure wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceMeasure WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceMeasure)WrappedObject; }
      }

      public PerformanceMeasure()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceMeasure()) {}

   }


}
