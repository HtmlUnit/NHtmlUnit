// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGGElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGGElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGElement o) =>
            new SVGGElement(o));
      }

      public SVGGElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGElement)WrappedObject; }
      }

      public SVGGElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGGElement()) {}

   }


}
