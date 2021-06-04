// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class PerformanceObserver : NHtmlUnit.Javascript.SimpleScriptable
   {
      static PerformanceObserver()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.PerformanceObserver o) =>
            new PerformanceObserver(o));
      }

      public PerformanceObserver(com.gargoylesoftware.htmlunit.javascript.host.PerformanceObserver wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.PerformanceObserver WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.PerformanceObserver)WrappedObject; }
      }

      public PerformanceObserver()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.PerformanceObserver()) {}

   }


}
