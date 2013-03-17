// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGPathElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGPathElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathElement o) =>
            new SVGPathElement(o));
      }

      public SVGPathElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathElement)WrappedObject; }
      }

      public SVGPathElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPathElement()) {}

   }


}
