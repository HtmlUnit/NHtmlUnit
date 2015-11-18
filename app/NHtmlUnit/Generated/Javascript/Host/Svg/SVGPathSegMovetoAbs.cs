// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGPathSegMovetoAbs : NHtmlUnit.Javascript.Host.Svg.SVGPathSeg
   {
      static SVGPathSegMovetoAbs()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegMovetoAbs o) =>
            new SVGPathSegMovetoAbs(o));
      }

      public SVGPathSegMovetoAbs(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegMovetoAbs wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegMovetoAbs WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegMovetoAbs)WrappedObject; }
      }

      public SVGPathSegMovetoAbs()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegMovetoAbs()) {}

   }


}
