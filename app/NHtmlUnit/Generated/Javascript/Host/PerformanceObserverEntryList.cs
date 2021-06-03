// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class PerformanceObserverEntryList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static PerformanceObserverEntryList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.PerformanceObserverEntryList o) =>
            new PerformanceObserverEntryList(o));
      }

      public PerformanceObserverEntryList(com.gargoylesoftware.htmlunit.javascript.host.PerformanceObserverEntryList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.PerformanceObserverEntryList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.PerformanceObserverEntryList)WrappedObject; }
      }

      public PerformanceObserverEntryList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.PerformanceObserverEntryList()) {}

   }


}
