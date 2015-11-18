// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGStyleElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGStyleElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGStyleElement o) =>
            new SVGStyleElement(o));
      }

      public SVGStyleElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGStyleElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGStyleElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGStyleElement)WrappedObject; }
      }

      public SVGStyleElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGStyleElement()) {}

   }


}
