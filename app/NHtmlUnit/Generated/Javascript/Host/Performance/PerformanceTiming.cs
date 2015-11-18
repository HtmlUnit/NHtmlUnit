// Generated class v2.19.0.0, don't modify

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

   }


}
