// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGPatternElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGPatternElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPatternElement o) =>
            new SVGPatternElement(o));
      }

      public SVGPatternElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPatternElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPatternElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPatternElement)WrappedObject; }
      }

      public SVGPatternElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPatternElement()) {}

   }


}
