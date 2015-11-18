// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGPathSegLinetoAbs : NHtmlUnit.Javascript.Host.Svg.SVGPathSeg
   {
      static SVGPathSegLinetoAbs()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegLinetoAbs o) =>
            new SVGPathSegLinetoAbs(o));
      }

      public SVGPathSegLinetoAbs(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegLinetoAbs wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegLinetoAbs WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegLinetoAbs)WrappedObject; }
      }

      public SVGPathSegLinetoAbs()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegLinetoAbs()) {}

   }


}
