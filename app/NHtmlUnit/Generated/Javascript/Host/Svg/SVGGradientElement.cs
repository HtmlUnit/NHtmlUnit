// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGGradientElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGGradientElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGradientElement o) =>
            new SVGGradientElement(o));
      }

      public SVGGradientElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGradientElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGradientElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGradientElement)WrappedObject; }
      }

      public SVGGradientElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGradientElement()) {}

   }


}
