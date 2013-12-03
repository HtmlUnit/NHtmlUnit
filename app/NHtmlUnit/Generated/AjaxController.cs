// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class AjaxController : ObjectWrapper
   {
      static AjaxController()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.AjaxController o) =>
            new AjaxController(o));
      }

      public AjaxController(com.gargoylesoftware.htmlunit.AjaxController wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.AjaxController WObj
      {
         get { return (com.gargoylesoftware.htmlunit.AjaxController)WrappedObject; }
      }

      public AjaxController()
         : this(new com.gargoylesoftware.htmlunit.AjaxController()) {}

// Generating method code for processSynchron
      public virtual bool ProcessSynchron(NHtmlUnit.Html.HtmlPage page, NHtmlUnit.WebRequest request, bool async)
      {
         return WObj.processSynchron((com.gargoylesoftware.htmlunit.html.HtmlPage)page.WrappedObject, (com.gargoylesoftware.htmlunit.WebRequest)request.WrappedObject, async);
      }

   }


}
