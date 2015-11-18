// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGPathSegMovetoRel : NHtmlUnit.Javascript.Host.Svg.SVGPathSeg
   {
      static SVGPathSegMovetoRel()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegMovetoRel o) =>
            new SVGPathSegMovetoRel(o));
      }

      public SVGPathSegMovetoRel(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegMovetoRel wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegMovetoRel WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegMovetoRel)WrappedObject; }
      }

      public SVGPathSegMovetoRel()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegMovetoRel()) {}

   }


}
