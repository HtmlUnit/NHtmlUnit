// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Moz
{
   public partial class MozPowerManager : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MozPowerManager()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.moz.MozPowerManager o) =>
            new MozPowerManager(o));
      }

      public MozPowerManager(com.gargoylesoftware.htmlunit.javascript.host.moz.MozPowerManager wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.moz.MozPowerManager WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.moz.MozPowerManager)WrappedObject; }
      }

      public MozPowerManager()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.moz.MozPowerManager()) {}

   }


}
