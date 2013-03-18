// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGForeignObjectElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGForeignObjectElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGForeignObjectElement o) =>
            new SVGForeignObjectElement(o));
      }

      public SVGForeignObjectElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGForeignObjectElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGForeignObjectElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGForeignObjectElement)WrappedObject; }
      }

      public SVGForeignObjectElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGForeignObjectElement()) {}

   }


}
