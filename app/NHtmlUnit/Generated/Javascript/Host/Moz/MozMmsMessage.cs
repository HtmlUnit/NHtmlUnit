// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Moz
{
   public partial class MozMmsMessage : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MozMmsMessage()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.moz.MozMmsMessage o) =>
            new MozMmsMessage(o));
      }

      public MozMmsMessage(com.gargoylesoftware.htmlunit.javascript.host.moz.MozMmsMessage wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.moz.MozMmsMessage WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.moz.MozMmsMessage)WrappedObject; }
      }

      public MozMmsMessage()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.moz.MozMmsMessage()) {}

   }


}
