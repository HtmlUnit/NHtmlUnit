// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class CollectingAlertHandler : ObjectWrapper, NHtmlUnit.IAlertHandler
   {
      static CollectingAlertHandler()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.CollectingAlertHandler o) =>
            new CollectingAlertHandler(o));
      }

      public CollectingAlertHandler(com.gargoylesoftware.htmlunit.CollectingAlertHandler wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.CollectingAlertHandler WObj
      {
         get { return (com.gargoylesoftware.htmlunit.CollectingAlertHandler)WrappedObject; }
      }

      public CollectingAlertHandler(java.util.List list)
         : this(new com.gargoylesoftware.htmlunit.CollectingAlertHandler(list)) {}

      public CollectingAlertHandler()
         : this(new com.gargoylesoftware.htmlunit.CollectingAlertHandler()) {}


      public IList<System.String> CollectedAlerts
      {
         get
         {
            return new ShallowListWrapper<System.String>(
               WObj.getCollectedAlerts());
         }
       }
// Generating method code for handleAlert
      public virtual void HandleAlert(NHtmlUnit.IPage page, string message)
      {
         WObj.handleAlert((com.gargoylesoftware.htmlunit.Page)page.WrappedObject, message);
      }

// Generating method code for clear
      public virtual void Clear()
      {
         WObj.clear();
      }

   }


}
