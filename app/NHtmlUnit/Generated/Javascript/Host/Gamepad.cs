// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Gamepad : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Gamepad()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Gamepad o) =>
            new Gamepad(o));
      }

      public Gamepad(com.gargoylesoftware.htmlunit.javascript.host.Gamepad wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Gamepad WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Gamepad)WrappedObject; }
      }

      public Gamepad()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Gamepad()) {}

   }


}
