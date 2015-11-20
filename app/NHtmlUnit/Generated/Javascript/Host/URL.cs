// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class URL : NHtmlUnit.Javascript.SimpleScriptable
   {
      static URL()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.URL o) =>
            new URL(o));
      }

      public URL(com.gargoylesoftware.htmlunit.javascript.host.URL wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.URL WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.URL)WrappedObject; }
      }

      public URL()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.URL()) {}

   }


}
