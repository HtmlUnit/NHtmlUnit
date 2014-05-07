// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGElement : NHtmlUnit.Javascript.Host.Element
   {
      static SVGElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGElement o) =>
            new SVGElement(o));
      }

      public SVGElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGElement)WrappedObject; }
      }

      public SVGElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGElement()) {}

   }


}
