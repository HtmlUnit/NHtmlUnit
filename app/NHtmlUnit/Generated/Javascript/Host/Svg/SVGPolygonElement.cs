// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGPolygonElement : NHtmlUnit.Javascript.Host.Svg.SVGGeometryElement
   {
      static SVGPolygonElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPolygonElement o) =>
            new SVGPolygonElement(o));
      }

      public SVGPolygonElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPolygonElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPolygonElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPolygonElement)WrappedObject; }
      }

      public SVGPolygonElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPolygonElement()) {}

   }


}
