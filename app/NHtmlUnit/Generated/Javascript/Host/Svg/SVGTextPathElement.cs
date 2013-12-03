// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGTextPathElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGTextPathElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTextPathElement o) =>
            new SVGTextPathElement(o));
      }

      public SVGTextPathElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTextPathElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTextPathElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTextPathElement)WrappedObject; }
      }

      public SVGTextPathElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGTextPathElement()) {}

   }


}
