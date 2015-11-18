// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGAngle : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGAngle()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAngle o) =>
            new SVGAngle(o));
      }

      public SVGAngle(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAngle wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAngle WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAngle)WrappedObject; }
      }

      public SVGAngle()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAngle()) {}

   }


}
