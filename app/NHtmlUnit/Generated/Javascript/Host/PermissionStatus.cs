// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class PermissionStatus : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static PermissionStatus()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.PermissionStatus o) =>
            new PermissionStatus(o));
      }

      public PermissionStatus(com.gargoylesoftware.htmlunit.javascript.host.PermissionStatus wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.PermissionStatus WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.PermissionStatus)WrappedObject; }
      }

      public PermissionStatus()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.PermissionStatus()) {}

   }


}
