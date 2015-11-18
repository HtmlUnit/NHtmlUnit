// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class PeriodicWave : NHtmlUnit.Javascript.SimpleScriptable
   {
      static PeriodicWave()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.PeriodicWave o) =>
            new PeriodicWave(o));
      }

      public PeriodicWave(com.gargoylesoftware.htmlunit.javascript.host.media.PeriodicWave wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.PeriodicWave WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.PeriodicWave)WrappedObject; }
      }

      public PeriodicWave()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.PeriodicWave()) {}

   }


}
