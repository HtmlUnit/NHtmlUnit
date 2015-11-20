// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Moz
{
   public partial class MozMobileMessageThread : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MozMobileMessageThread()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.moz.MozMobileMessageThread o) =>
            new MozMobileMessageThread(o));
      }

      public MozMobileMessageThread(com.gargoylesoftware.htmlunit.javascript.host.moz.MozMobileMessageThread wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.moz.MozMobileMessageThread WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.moz.MozMobileMessageThread)WrappedObject; }
      }

      public MozMobileMessageThread()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.moz.MozMobileMessageThread()) {}

   }


}
