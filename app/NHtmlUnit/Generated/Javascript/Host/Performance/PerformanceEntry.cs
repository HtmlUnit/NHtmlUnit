// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Performance
{
   public partial class PerformanceEntry : NHtmlUnit.Javascript.SimpleScriptable
   {
      static PerformanceEntry()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceEntry o) =>
            new PerformanceEntry(o));
      }

      public PerformanceEntry(com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceEntry wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceEntry WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceEntry)WrappedObject; }
      }

      public PerformanceEntry()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceEntry()) {}

   }


}
