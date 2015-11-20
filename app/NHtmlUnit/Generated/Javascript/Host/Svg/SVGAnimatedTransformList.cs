// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGAnimatedTransformList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static SVGAnimatedTransformList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedTransformList o) =>
            new SVGAnimatedTransformList(o));
      }

      public SVGAnimatedTransformList(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedTransformList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedTransformList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedTransformList)WrappedObject; }
      }

      public SVGAnimatedTransformList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimatedTransformList()) {}

   }


}
