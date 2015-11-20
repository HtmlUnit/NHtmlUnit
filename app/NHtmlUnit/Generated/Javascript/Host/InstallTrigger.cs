// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class InstallTrigger : NHtmlUnit.Javascript.SimpleScriptable
   {
      static InstallTrigger()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.InstallTrigger o) =>
            new InstallTrigger(o));
      }

      public InstallTrigger(com.gargoylesoftware.htmlunit.javascript.host.InstallTrigger wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.InstallTrigger WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.InstallTrigger)WrappedObject; }
      }

      public InstallTrigger()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.InstallTrigger()) {}

   }


}
