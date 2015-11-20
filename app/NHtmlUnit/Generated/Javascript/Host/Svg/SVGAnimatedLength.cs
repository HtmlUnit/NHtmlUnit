// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGAnimatedLength : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGAnimatedLength()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedLength o) =>
            new SVGAnimatedLength(o));
      }

      public SVGAnimatedLength(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedLength wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedLength WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedLength)WrappedObject; }
      }

      public SVGAnimatedLength()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedLength()) {}

   }


}
