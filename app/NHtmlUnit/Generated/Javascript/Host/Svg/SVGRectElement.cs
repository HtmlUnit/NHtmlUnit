// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGRectElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGRectElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGRectElement o) =>
            new SVGRectElement(o));
      }

      public SVGRectElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGRectElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGRectElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGRectElement)WrappedObject; }
      }

      public SVGRectElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGRectElement()) {}

   }


}
