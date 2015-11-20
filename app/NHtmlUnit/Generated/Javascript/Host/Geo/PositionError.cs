// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Geo
{
   public partial class PositionError : NHtmlUnit.Javascript.SimpleScriptable
   {
      static PositionError()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.geo.PositionError o) =>
            new PositionError(o));
      }

      public PositionError(com.gargoylesoftware.htmlunit.javascript.host.geo.PositionError wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.geo.PositionError WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.geo.PositionError)WrappedObject; }
      }

      public PositionError()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.geo.PositionError()) {}

   }


}
