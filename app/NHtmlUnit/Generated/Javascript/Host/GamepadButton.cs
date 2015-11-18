// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class GamepadButton : NHtmlUnit.Javascript.SimpleScriptable
   {
      static GamepadButton()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.GamepadButton o) =>
            new GamepadButton(o));
      }

      public GamepadButton(com.gargoylesoftware.htmlunit.javascript.host.GamepadButton wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.GamepadButton WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.GamepadButton)WrappedObject; }
      }

      public GamepadButton()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.GamepadButton()) {}

   }


}
