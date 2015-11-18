// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGPathSeg : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGPathSeg()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSeg o) =>
            new SVGPathSeg(o));
      }

      public SVGPathSeg(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSeg wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSeg WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSeg)WrappedObject; }
      }

      public SVGPathSeg()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathSeg()) {}

   }


}
