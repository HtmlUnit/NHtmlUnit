// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGAnimationElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGAnimationElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimationElement o) =>
            new SVGAnimationElement(o));
      }

      public SVGAnimationElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimationElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimationElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimationElement)WrappedObject; }
      }

      public SVGAnimationElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAnimationElement()) {}

   }


}
