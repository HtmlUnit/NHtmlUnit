// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Moz
{
   public partial class MozMobileMessageManager : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static MozMobileMessageManager()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.moz.MozMobileMessageManager o) =>
            new MozMobileMessageManager(o));
      }

      public MozMobileMessageManager(com.gargoylesoftware.htmlunit.javascript.host.moz.MozMobileMessageManager wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.moz.MozMobileMessageManager WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.moz.MozMobileMessageManager)WrappedObject; }
      }

      public MozMobileMessageManager()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.moz.MozMobileMessageManager()) {}

   }


}
