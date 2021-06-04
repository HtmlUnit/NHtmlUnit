// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGLineElement : NHtmlUnit.Javascript.Host.Svg.SVGGeometryElement
   {
      static SVGLineElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGLineElement o) =>
            new SVGLineElement(o));
      }

      public SVGLineElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGLineElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGLineElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGLineElement)WrappedObject; }
      }

      public SVGLineElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGLineElement()) {}

   }


}
