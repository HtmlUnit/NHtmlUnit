// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGFEImageElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGFEImageElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGFEImageElement o) =>
            new SVGFEImageElement(o));
      }

      public SVGFEImageElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGFEImageElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGFEImageElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGFEImageElement)WrappedObject; }
      }

      public SVGFEImageElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGFEImageElement()) {}

   }


}
