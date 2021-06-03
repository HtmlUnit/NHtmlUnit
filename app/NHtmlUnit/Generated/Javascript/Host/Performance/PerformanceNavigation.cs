// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Performance
{
   public partial class PerformanceNavigation : NHtmlUnit.Javascript.SimpleScriptable
   {
      static PerformanceNavigation()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceNavigation o) =>
            new PerformanceNavigation(o));
      }

      public PerformanceNavigation(com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceNavigation wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceNavigation WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceNavigation)WrappedObject; }
      }

      public PerformanceNavigation()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.performance.PerformanceNavigation()) {}


      public System.Int32 Type
      {
         get
         {
            return WObj.getType();
         }
      }

      public System.Int32 RedirectCount
      {
         get
         {
            return WObj.getRedirectCount();
         }
      }
// Generating method code for toJSON
      public virtual object ToJSON()
      {
         var arg = WObj.toJSON();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

   }


}
