// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Netscape : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Netscape()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Netscape o) =>
            new Netscape(o));
      }

      public Netscape(com.gargoylesoftware.htmlunit.javascript.host.Netscape wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Netscape WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Netscape)WrappedObject; }
      }

   }


}
