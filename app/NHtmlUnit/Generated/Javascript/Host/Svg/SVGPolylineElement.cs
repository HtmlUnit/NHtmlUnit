// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGPolylineElement : NHtmlUnit.Javascript.Host.Svg.SVGGeometryElement
   {
      static SVGPolylineElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPolylineElement o) =>
            new SVGPolylineElement(o));
      }

      public SVGPolylineElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPolylineElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPolylineElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPolylineElement)WrappedObject; }
      }

      public SVGPolylineElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGPolylineElement()) {}

   }


}
