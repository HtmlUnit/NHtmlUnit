// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGPoint : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGPoint()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPoint o) =>
            new SVGPoint(o));
      }

      public SVGPoint(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPoint wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPoint WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPoint)WrappedObject; }
      }

      public SVGPoint()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPoint()) {}

   }


}
