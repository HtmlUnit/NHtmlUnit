// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGPathSegArcAbs : NHtmlUnit.Javascript.Host.Svg.SVGPathSeg
   {
      static SVGPathSegArcAbs()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegArcAbs o) =>
            new SVGPathSegArcAbs(o));
      }

      public SVGPathSegArcAbs(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegArcAbs wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegArcAbs WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegArcAbs)WrappedObject; }
      }

      public SVGPathSegArcAbs()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegArcAbs()) {}

   }


}
