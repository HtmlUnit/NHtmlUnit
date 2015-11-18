// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGPathSegLinetoRel : NHtmlUnit.Javascript.Host.Svg.SVGPathSeg
   {
      static SVGPathSegLinetoRel()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegLinetoRel o) =>
            new SVGPathSegLinetoRel(o));
      }

      public SVGPathSegLinetoRel(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegLinetoRel wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegLinetoRel WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegLinetoRel)WrappedObject; }
      }

      public SVGPathSegLinetoRel()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegLinetoRel()) {}

   }


}
