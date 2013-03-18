// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGUseElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGUseElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGUseElement o) =>
            new SVGUseElement(o));
      }

      public SVGUseElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGUseElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGUseElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGUseElement)WrappedObject; }
      }

      public SVGUseElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGUseElement()) {}

   }


}
