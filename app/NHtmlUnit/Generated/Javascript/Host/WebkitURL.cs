// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class WebkitURL : NHtmlUnit.Javascript.Host.URL
   {
      static WebkitURL()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.webkitURL o) =>
            new WebkitURL(o));
      }

      public WebkitURL(com.gargoylesoftware.htmlunit.javascript.host.webkitURL wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.webkitURL WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.webkitURL)WrappedObject; }
      }

      public WebkitURL()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.webkitURL()) {}

   }


}
