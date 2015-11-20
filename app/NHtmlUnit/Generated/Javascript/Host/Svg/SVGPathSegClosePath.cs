// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGPathSegClosePath : NHtmlUnit.Javascript.Host.Svg.SVGPathSeg
   {
      static SVGPathSegClosePath()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegClosePath o) =>
            new SVGPathSegClosePath(o));
      }

      public SVGPathSegClosePath(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegClosePath wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegClosePath WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegClosePath)WrappedObject; }
      }

      public SVGPathSegClosePath()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSegClosePath()) {}

   }


}
