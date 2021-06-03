// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class HttpMethod : ObjectWrapper
   {
      static HttpMethod()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.HttpMethod o) =>
            new HttpMethod(o));
      }

      public HttpMethod(com.gargoylesoftware.htmlunit.HttpMethod wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.HttpMethod WObj
      {
         get { return (com.gargoylesoftware.htmlunit.HttpMethod)WrappedObject; }
      }

   }


}
