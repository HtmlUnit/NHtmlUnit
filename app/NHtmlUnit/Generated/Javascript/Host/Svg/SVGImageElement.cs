// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGImageElement : NHtmlUnit.Javascript.Host.Svg.SVGGraphicsElement
   {
      static SVGImageElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGImageElement o) =>
            new SVGImageElement(o));
      }

      public SVGImageElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGImageElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGImageElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGImageElement)WrappedObject; }
      }

      public SVGImageElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGImageElement()) {}

   }


}
