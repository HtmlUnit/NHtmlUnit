// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGAnimatedInteger : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGAnimatedInteger()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedInteger o) =>
            new SVGAnimatedInteger(o));
      }

      public SVGAnimatedInteger(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedInteger wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedInteger WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedInteger)WrappedObject; }
      }

      public SVGAnimatedInteger()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedInteger()) {}

   }


}
