// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGGeometryElement : NHtmlUnit.Javascript.Host.Svg.SVGGraphicsElement
   {
      static SVGGeometryElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGeometryElement o) =>
            new SVGGeometryElement(o));
      }

      public SVGGeometryElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGeometryElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGeometryElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGeometryElement)WrappedObject; }
      }

      public SVGGeometryElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGeometryElement()) {}

   }


}
