// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Performance
{
   public partial class Performance : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static Performance()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.performance.Performance o) =>
            new Performance(o));
      }

      public Performance(com.gargoylesoftware.htmlunit.javascript.host.performance.Performance wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.performance.Performance WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.performance.Performance)WrappedObject; }
      }

      public Performance()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.performance.Performance()) {}


      public NHtmlUnit.Javascript.Host.Performance.PerformanceNavigation Navigation
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Performance.PerformanceNavigation>(
               WObj.getNavigation());
         }
      }

   }


}
