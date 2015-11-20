// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Moz
{
   public partial class MozSmsMessage : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MozSmsMessage()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.moz.MozSmsMessage o) =>
            new MozSmsMessage(o));
      }

      public MozSmsMessage(com.gargoylesoftware.htmlunit.javascript.host.moz.MozSmsMessage wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.moz.MozSmsMessage WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.moz.MozSmsMessage)WrappedObject; }
      }

      public MozSmsMessage()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.moz.MozSmsMessage()) {}

   }


}
