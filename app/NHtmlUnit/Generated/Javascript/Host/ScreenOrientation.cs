// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class ScreenOrientation : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static ScreenOrientation()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.ScreenOrientation o) =>
            new ScreenOrientation(o));
      }

      public ScreenOrientation(com.gargoylesoftware.htmlunit.javascript.host.ScreenOrientation wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.ScreenOrientation WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.ScreenOrientation)WrappedObject; }
      }

      public ScreenOrientation()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.ScreenOrientation()) {}

   }


}
