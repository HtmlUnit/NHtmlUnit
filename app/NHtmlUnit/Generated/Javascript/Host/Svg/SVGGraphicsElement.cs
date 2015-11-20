// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGGraphicsElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGGraphicsElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGraphicsElement o) =>
            new SVGGraphicsElement(o));
      }

      public SVGGraphicsElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGraphicsElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGraphicsElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGraphicsElement)WrappedObject; }
      }

      public SVGGraphicsElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGraphicsElement()) {}

   }


}
