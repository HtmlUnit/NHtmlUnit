// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGAnimatedNumber : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGAnimatedNumber()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedNumber o) =>
            new SVGAnimatedNumber(o));
      }

      public SVGAnimatedNumber(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedNumber wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedNumber WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedNumber)WrappedObject; }
      }

      public SVGAnimatedNumber()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedNumber()) {}

   }


}
