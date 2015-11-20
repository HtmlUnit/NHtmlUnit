// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class NicelyResynchronizingAjaxController : NHtmlUnit.AjaxController
   {
      static NicelyResynchronizingAjaxController()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.NicelyResynchronizingAjaxController o) =>
            new NicelyResynchronizingAjaxController(o));
      }

      public NicelyResynchronizingAjaxController(com.gargoylesoftware.htmlunit.NicelyResynchronizingAjaxController wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.NicelyResynchronizingAjaxController WObj
      {
         get { return (com.gargoylesoftware.htmlunit.NicelyResynchronizingAjaxController)WrappedObject; }
      }

      public NicelyResynchronizingAjaxController()
         : this(new com.gargoylesoftware.htmlunit.NicelyResynchronizingAjaxController()) {}

   }


}
