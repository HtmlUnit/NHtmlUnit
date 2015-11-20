// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Performance
{
   public partial class PerformanceMark : NHtmlUnit.Javascript.Host.Performance.PerformanceEntry
   {
      static PerformanceMark()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceMark o) =>
            new PerformanceMark(o));
      }

      public PerformanceMark(com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceMark wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceMark WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceMark)WrappedObject; }
      }

      public PerformanceMark()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceMark()) {}

   }


}
