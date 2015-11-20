// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGMPathElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGMPathElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGMPathElement o) =>
            new SVGMPathElement(o));
      }

      public SVGMPathElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGMPathElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGMPathElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGMPathElement)WrappedObject; }
      }

      public SVGMPathElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGMPathElement()) {}

   }


}
