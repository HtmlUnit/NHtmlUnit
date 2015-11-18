// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class URLSearchParams : NHtmlUnit.Javascript.SimpleScriptable
   {
      static URLSearchParams()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.URLSearchParams o) =>
            new URLSearchParams(o));
      }

      public URLSearchParams(com.gargoylesoftware.htmlunit.javascript.host.URLSearchParams wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.URLSearchParams WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.URLSearchParams)WrappedObject; }
      }

      public URLSearchParams()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.URLSearchParams()) {}

   }


}
