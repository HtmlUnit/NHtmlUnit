// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGViewElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGViewElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGViewElement o) =>
            new SVGViewElement(o));
      }

      public SVGViewElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGViewElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGViewElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGViewElement)WrappedObject; }
      }

      public SVGViewElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGViewElement()) {}

   }


}
