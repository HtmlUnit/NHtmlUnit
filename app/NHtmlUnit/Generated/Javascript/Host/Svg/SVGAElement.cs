// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGAElement : NHtmlUnit.Javascript.Host.Svg.SVGElement
   {
      static SVGAElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAElement o) =>
            new SVGAElement(o));
      }

      public SVGAElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAElement)WrappedObject; }
      }

      public SVGAElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGAElement()) {}

   }


}
