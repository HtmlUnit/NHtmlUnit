// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGPathSegArcRel : NHtmlUnit.Javascript.Host.Svg.SVGPathSeg
   {
      static SVGPathSegArcRel()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegArcRel o) =>
            new SVGPathSegArcRel(o));
      }

      public SVGPathSegArcRel(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegArcRel wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegArcRel WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegArcRel)WrappedObject; }
      }

      public SVGPathSegArcRel()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegArcRel()) {}

   }


}
