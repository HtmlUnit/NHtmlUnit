// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Util
{
   public partial class WebResponseWrapper : NHtmlUnit.WebResponse
   {
      static WebResponseWrapper()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.util.WebResponseWrapper o) =>
            new WebResponseWrapper(o));
      }

      public WebResponseWrapper(com.gargoylesoftware.htmlunit.util.WebResponseWrapper wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.util.WebResponseWrapper WObj
      {
         get { return (com.gargoylesoftware.htmlunit.util.WebResponseWrapper)WrappedObject; }
      }

      public WebResponseWrapper(NHtmlUnit.WebResponse webResponse)
         : this(new com.gargoylesoftware.htmlunit.util.WebResponseWrapper((com.gargoylesoftware.htmlunit.WebResponse)webResponse.WrappedObject)) {}

   }


}
