// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGDescElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGDescElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGDescElement o) =>
            new SVGDescElement(o));
      }

      public SVGDescElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGDescElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGDescElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGDescElement)WrappedObject; }
      }

      public SVGDescElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGDescElement()) {}

   }


}
