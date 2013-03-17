// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGSetElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGSetElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGSetElement o) =>
            new SVGSetElement(o));
      }

      public SVGSetElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGSetElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGSetElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGSetElement)WrappedObject; }
      }

      public SVGSetElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGSetElement()) {}

   }


}
