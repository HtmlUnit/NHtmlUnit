// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class TextEncoder : NHtmlUnit.Javascript.SimpleScriptable
   {
      static TextEncoder()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.TextEncoder o) =>
            new TextEncoder(o));
      }

      public TextEncoder(com.gargoylesoftware.htmlunit.javascript.host.TextEncoder wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.TextEncoder WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.TextEncoder)WrappedObject; }
      }

      public TextEncoder()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.TextEncoder()) {}

   }


}
