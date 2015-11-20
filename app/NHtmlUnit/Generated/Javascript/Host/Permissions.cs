// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Permissions : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Permissions()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Permissions o) =>
            new Permissions(o));
      }

      public Permissions(com.gargoylesoftware.htmlunit.javascript.host.Permissions wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Permissions WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Permissions)WrappedObject; }
      }

      public Permissions()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Permissions()) {}

   }


}
