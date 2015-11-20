// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGAnimatedAngle : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGAnimatedAngle()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedAngle o) =>
            new SVGAnimatedAngle(o));
      }

      public SVGAnimatedAngle(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedAngle wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedAngle WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedAngle)WrappedObject; }
      }

      public SVGAnimatedAngle()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedAngle()) {}

   }


}
